# Base de datos: modelo de datos de telemetría

EmotionLAB no usa una base de datos relacional. Cada sesión se guarda como **un documento JSON** (esquema semiestructurado) en **Amazon S3**, al que se accede solo a través de **Amazon API Gateway → AWS Lambda**. Toda la infraestructura está declarada en Terraform.

| Campo | Tipo | Descripción |
|---|---|---|
| `idParticipante` | texto | Identificador anónimo de la sesión (fecha, hora y sufijo aleatorio) |
| `fechaInicio` / `fechaFin` | fecha y hora | Inicio y término de la sesión |
| `difficulty_level` | texto | Nivel de dificultad alcanzado (`facil` / `dificil`) |
| `facilCompletado` / `dificilCompletado` | booleano | Modos completados |
| `retryUsado` | booleano | Si el estudiante repitió la experiencia |
| `ultimoModoCompletado` | texto | Último modo terminado |
| `respuestas[]` | lista | Respuestas por escena: `escena`, `idPregunta`, `textoPregunta`, `respuestaLabel`, `respuestaIndex`, `timestamp` |

Ejemplo completo: [`modelo_datos_sesion.json`](modelo_datos_sesion.json).

**Decisiones de diseño**
- **S3 en vez de una base relacional:** los datos son semiestructurados, se escriben una vez por sesión y no requieren joins.
- **Guardado local primero:** la app guarda el JSON en el visor y luego lo sincroniza con S3 (RNF-006), para no perder sesiones si el entorno de AWS no está activo.
- **Privacidad (RNF-008):** identificador anónimo y edad por rango; no se almacena nombre, RUT ni correo.
- **Validación:** la Lambda rechaza con `400 Bad Request` un JSON sin identificador de sesión (prueba PU-01); un envío válido responde `200 OK` y queda en S3 (prueba PI-01).

Los diagramas de arquitectura están en la carpeta *Evidencias de Sistema*.
