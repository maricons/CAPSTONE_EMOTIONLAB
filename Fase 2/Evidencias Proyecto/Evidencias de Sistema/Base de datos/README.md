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

## Catálogo de preguntas del formulario inicial (escena `waiting_room_inicial`)

| idPregunta | textoPregunta | Tipo de respuesta |
|---|---|---|
| `edad` | ¿Cuál es tu edad? | Lista de edades |
| `sentir_hoy` | ¿Cómo te sientes hoy? | Escala de 9 caritas (1 a 9), del verde al rojo |
| `nerviosismo` | ¿Te sientes nervioso? | Escala de 9 caritas (1 a 9), del verde al rojo |
| `preocupacion` | ¿Te sientes preocupado? | Escala de 9 caritas (1 a 9), del verde al rojo |
| `preparacion` | ¿Te sientes preparado? | Escala de 9 caritas (1 a 9), del verde al rojo |

`respuestaLabel` guarda el valor elegido y `respuestaIndex` su posición en la lista de opciones. El formulario final de la retroalimentación vuelve a registrar el estado emocional con la misma escala, para comparar el inicio con el final de la sesión.

**Decisiones de diseño**
- **S3 en vez de una base relacional:** los datos son semiestructurados, se escriben una vez por sesión y no requieren joins.
- **Guardado local primero:** la app guarda el JSON en el visor y luego lo sincroniza con S3 (RNF-006), para no perder sesiones si el entorno de AWS no está activo.
- **Privacidad (RNF-008):** identificador anónimo y edad elegida de una lista, sin fecha de nacimiento; no se almacena nombre, RUT ni correo.
- **Validación:** la Lambda rechaza con `400 Bad Request` un JSON sin identificador de sesión (prueba PU-01); un envío válido responde `200 OK` y queda en S3 (prueba PI-01).

Los diagramas de arquitectura están en la carpeta *Evidencias de Sistema*.
