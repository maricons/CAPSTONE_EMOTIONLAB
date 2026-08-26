# EmotionLab VR

Un espacio en Realidad Virtual para regular las emociones de adolescentes antes de una presentación, y celebrarlo después con una experiencia relajante.

## 📖 Descripción

**EmotionLab** es un proyecto de Realidad Virtual desarrollado como Proyecto de Título (Capstone) en Duoc UC, orientado a resolver la dificultad que presentan los establecimientos educativos para medir e interpretar de forma objetiva las respuestas emocionales y de atención en estudiantes de Enseñanza Media, particularmente en momentos de alta exigencia como exponer una presentación (PPT) frente a un curso.

Tradicionalmente los colegios dependen de observaciones subjetivas o encuestas manuales que no logran capturar la experiencia real del estudiante en tiempo real. EmotionLab combina un entorno inmersivo en VR con captura y análisis de datos para entregar información objetiva que apoye la toma de decisiones pedagógicas.

## 🧠 El problema

- Los y las estudiantes casi nunca se preparan emocionalmente para momentos de alta exigencia (exponer, evaluarse, presentar), solo los viven el día del evento.
- El estrés y la ansiedad afectan la concentración y la claridad justo cuando más se necesitan.
- Existen pocas herramientas simples, guiadas y accesibles para regular la emoción antes de actuar.
- Los colegios no cuentan con datos objetivos y en tiempo real sobre el estado emocional de sus estudiantes durante estos procesos.

## 🕹️ La experiencia

Con un visor de Realidad Virtual, cada estudiante recorre un breve recorrido guiado antes y después de presentar:

1. **Check-in inicial** — un breve registro de cómo se siente el/la estudiante antes de comenzar.
2. **Ejercicio de respiración** — una guía de respiración y anclaje físico dentro de un entorno simulado, para bajar la ansiedad justo antes de presentar.
3. **Presentación** — el/la estudiante expone su PPT en la vida real, ya con un estado emocional más regulado.
4. **Sala cozy de cierre** — al terminar, una experiencia grata y relajante de recolección de patitos alrededor de una sala acogedora ("cozy room"), como cierre positivo de la experiencia.

Durante todo el recorrido se capturan métricas de comportamiento y respuesta socioemocional, que alimentan un dashboard analítico de Inteligencia de Negocios para que los y las docentes orienten sus metodologías.

## 🛠️ Stack tecnológico

| Área | Tecnología |
|---|---|
| Motor / Entorno VR | Unity |
| Dispositivo | Visor de Realidad Virtual (build APK) |
| Backend / datos | Servidor en AWS, API de transmisión de datos |
| Almacenamiento | Base de datos para registros de sesión (anonimizados) |
| Analítica | Dashboard de Inteligencia de Negocios (BI) |
| Gestión del proyecto | GitHub Projects (metodología Kanban) |

> Ajusta esta tabla con las versiones y herramientas específicas que finalmente use el equipo (versión de Unity, motor de base de datos, herramienta de BI, etc.).

## 👥 Equipo

Proyecto desarrollado por estudiantes de Ingeniería en Informática, Duoc UC:

- **Constanza Quiero** — Documentación formal del proyecto y gestión de assets del entorno VR (organización, limpieza y estandarización de la librería de assets en Unity).
- **Kathleen Ampuero** — Pruebas funcionales de la aplicación VR, corrección de errores (bug fixing) y generación de builds APK para despliegue en los visores.
- **Katalina Pérez** — Integración de la API y conexión con el servidor en AWS, transmisión y disponibilización de los datos capturados hacia el equipo encargado del modelo de BI/IA.

Todas las integrantes participan de forma transversal en las pruebas de la aplicación y en el versionamiento del proyecto mediante GitHub.

## 🗓️ Metodología y fases

El proyecto se desarrolla con metodología ágil **Kanban**, gestionada en un tablero visual (GitHub Projects), organizado en tres fases alineadas al período académico:

- **Fase 1 — Planificación y documentación:** definición del proyecto, Acta de Constitución, Especificación de Requerimientos (ERS/SRS), Carta de Compromiso con el colegio participante.
- **Fase 2 — Desarrollo y pruebas de campo:** diseño e implementación del entorno VR, construcción de la arquitectura de datos, coordinación con el colegio, consentimientos informados, pruebas con estudiantes.
- **Fase 3 — Cierre:** consolidación de la documentación final, defensa del proyecto ante el tribunal evaluador.

## 🔐 Privacidad y datos

Dado que el proyecto trabaja con estudiantes menores de edad, se aplican protocolos de:

- Anonimización estricta de los datos capturados.
- Cifrado de la información.
- Consentimientos informados firmados por los apoderados.

## 🗂️ Estructura del proyecto

```
EmotionLab/
├── Assets/            # Assets y escenas de Unity (entorno VR)
├── Builds/             # Builds APK generadas para el visor
├── Backend/           # API / integración con AWS
├── Docs/               # Documentación del proyecto (Acta, ERS/SRS, evidencias)
└── README.md
```

> Actualiza este árbol con la estructura real del repositorio una vez subido el código.

## 🚀 Cómo ejecutar

1. Clonar este repositorio.
2. Abrir la carpeta del proyecto en Unity (versión a especificar).
3. Conectar el visor de Realidad Virtual compatible.
4. Generar el build APK y desplegar en el visor.
5. (Opcional) Configurar las credenciales de AWS para la transmisión de datos.

> Completa esta sección con los pasos exactos, versión de Unity y requisitos de hardware una vez definidos.

## 🏫 Contexto académico

Proyecto desarrollado para la asignatura **Capstone (Portafolio de Título)**, Ingeniería en Informática, Duoc UC, en colaboración con un colegio de Viña del Mar como entidad interesada.

## 📄 Licencia

Uso académico
