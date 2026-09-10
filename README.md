# EmotionLAB VR

Proyecto Capstone — Ingeniería en Informática, Duoc UC (sede Viña del Mar)

Repositorio: https://github.com/maricons/CAPSTONE_EMOTIONLAB

<p>
  <img src="https://img.shields.io/badge/Unity-000000?style=for-the-badge&logo=unity&logoColor=white" alt="Unity">
  <img src="https://img.shields.io/badge/C%23-512BD4?style=for-the-badge&logo=csharp&logoColor=white" alt="C#">
  <img src="https://img.shields.io/badge/Meta%20Quest-0467DF?style=for-the-badge&logo=meta&logoColor=white" alt="Meta Quest">
  <img src="https://img.shields.io/badge/Universal%20RP-000000?style=for-the-badge&logo=unity&logoColor=white" alt="Universal Render Pipeline">
</p>

<p>
  <img src="https://img.shields.io/badge/AWS-232F3E?style=for-the-badge&logo=amazonwebservices&logoColor=white" alt="AWS">
  <img src="https://img.shields.io/badge/API%20Gateway-FF4F8B?style=for-the-badge&logo=amazonapigateway&logoColor=white" alt="Amazon API Gateway">
  <img src="https://img.shields.io/badge/Lambda-FF9900?style=for-the-badge&logo=awslambda&logoColor=white" alt="AWS Lambda">
  <img src="https://img.shields.io/badge/S3-569A31?style=for-the-badge&logo=amazons3&logoColor=white" alt="Amazon S3">
  <img src="https://img.shields.io/badge/Terraform-7B42BC?style=for-the-badge&logo=terraform&logoColor=white" alt="Terraform">
  <img src="https://img.shields.io/badge/Python-3776AB?style=for-the-badge&logo=python&logoColor=white" alt="Python">
</p>

<p>
  <img src="https://img.shields.io/badge/Git-F05032?style=for-the-badge&logo=git&logoColor=white" alt="Git">
  <img src="https://img.shields.io/badge/GitHub%20Projects-181717?style=for-the-badge&logo=github&logoColor=white" alt="GitHub Projects">
  <img src="https://img.shields.io/badge/Kanban-0052CC?style=for-the-badge&logo=trello&logoColor=white" alt="Kanban">
</p>

## Contexto

**EmotionLAB es un proyecto de continuidad.** Existe una versión previa de EmotionLAB orientada a estudiantes de **educación superior**. Esta fase toma ese proyecto y lo reorienta a **estudiantes de Enseñanza Media (adolescentes)**, incorporando **gamificación** en la experiencia.

El proyecto se desarrolla en el marco de la asignatura Capstone, en colaboración con un colegio real de la comuna de Viña del Mar, por un equipo de tres estudiantes de Ingeniería en Informática.

Somos el **equipo de desarrollo y diseño de la aplicación**, y las responsables de la telemetría: la captura de los datos comportamentales durante la experiencia y su transmisión hacia la nube mediante API.

El trabajo está repartido entre dos equipos:

| Equipo | Responsabilidad |
|---|---|
| **Nuestro equipo** | **Desarrollo y diseño de la aplicación**: construimos la experiencia de realidad virtual completa (escenarios, recorrido, gamificación e identidad visual). Somos además las encargadas de la **telemetría** y de la **captura y transmisión de los datos comportamentales hacia la nube mediante API**. |
| **Equipo de IA** | **Modelo, clasificación y dashboard**: procesa los datos comportamentales, clasifica y genera los insights que se presentan al docente o psicopedagogo. |

## El Problema

Existe un **déficit de gestión emocional** en adolescentes frente a situaciones de alta exigencia, como una **exposición oral o una entrevista**. Presentarse frente a otros activa niveles de estrés que muchos estudiantes no logran regular por sí solos.

A esto se suma que el docente o psicopedagogo que acompaña el proceso no cuenta con **evidencia comportamental** que le permita identificar quién necesita apoyo y en qué momento. La observación en aula es puntual y ocurre mientras la instancia ya está en curso.

## Propuesta de Valor

> EmotionLAB **no convierte la emoción en información**. Convierte los **datos comportamentales** en datos útiles para la toma de decisiones del profesor o psicopedagogo.

EmotionLAB es una **herramienta complementaria** de apoyo a la regulación emocional. Es una experiencia de realidad virtual que sitúa al estudiante en una situación de exigencia (exposición o entrevista) y, a partir de los **datos comportamentales** registrados durante el recorrido, permite clasificar si el sujeto **regula o no regula** sus emociones en esa situación.

No es un diagnóstico clínico ni reemplaza el trabajo del docente: es evidencia adicional para acompañar mejor al estudiante.

### El recorrido

1. **Sala de espera** — check-in inicial y ambientación.
2. **1ª presentación** (sala pequeña) — con ejercicio de respiración guiada previo, para regular el nivel de activación.
3. **2ª presentación** (Oficina, con audiencia) — mayor exigencia, con su propia respiración guiada previa.
4. **Retroalimentación** — ejercicio final de respiración guiada y una encuesta breve de autorreporte sobre cómo se siente el estudiante tras la experiencia.
5. **Cierre** — al responder la encuesta se pasa a una escena distinta: un minijuego de recolección de patitos en una sala *cozy*, como espacio de descompresión positiva con el que termina la experiencia.

Todo el recorrido queda registrado mediante telemetría, permitiendo comparar el comportamiento del estudiante antes y después de la instancia. Los datos se transmiten de forma **segura y anonimizada** hacia la nube, donde el equipo de IA los procesa. Al tratarse de estudiantes adolescentes, la privacidad se resguarda en todo momento: ningún dato identifica a un estudiante y cada apoderado autoriza la participación mediante consentimiento informado.

## Tecnologías

| Área | Herramientas |
|---|---|
| Experiencia VR | **Unity** (URP) · **visores Meta Quest** (standalone) |
| Nube y datos | **Amazon API Gateway** · **AWS Lambda** · **Amazon S3** |
| Infraestructura | **Terraform** (infraestructura como código) · **AWS Academy Learner Lab** |
| Gestión y versionamiento | **GitHub** (control de versiones y ramas) · **GitHub Projects** (tablero Kanban) |
| Planificación | **Carta Gantt** de 13 semanas |

## Arquitectura de datos

La telemetría es responsabilidad de nuestro equipo: la aplicación captura los datos comportamentales durante el recorrido y los transmite a la nube mediante una API. La arquitectura es **serverless** y está descrita íntegramente como código con Terraform.

```
  Meta Quest (app Unity)
          │  HTTPS / JSON
          ▼
  Amazon API Gateway     puerta de entrada única
          ▼
  AWS Lambda             procesamiento de las sesiones
          ▼
  Amazon S3              sesiones en JSON, organizadas por fecha
          ▼
  Equipo de IA           modelo de clasificación y dashboard
```

### Decisiones de diseño

- **Serverless en vez de un servidor tradicional.** No hay infraestructura encendida de forma permanente: se paga solo por el tiempo de ejecución de cada petición, y no hay sistema operativo que mantener ni parchear.
- **Responsabilidades separadas.** La lógica está dividida en funciones independientes, de modo que un error en una no deja sin servicio al resto y cada integrante puede intervenir una parte sin arriesgar las demás.
- **S3 en lugar de una base de datos relacional.** Los datos que produce Unity son semiestructurados (métricas, tiempos y registros de interacción en JSON); guardarlos como archivos particionados por fecha evita una capa de modelado relacional que el caso no necesita, con alta durabilidad y costo mínimo.
- **API Gateway como puerta de entrada única.** La aplicación en Unity nunca conoce el bucket ni las funciones: solo consume un endpoint HTTPS. Esto permite que más adelante un dashboard web consuma la misma API sin cambios de infraestructura.
- **Infraestructura como código con Terraform.** Todo el entorno se recrea con un solo comando en cualquier cuenta de AWS, y el propio código actúa como documentación técnica de qué recursos existen y cómo se conectan.

La infraestructura corre sobre una cuenta de **AWS Academy Learner Lab**, cuyas credenciales son temporales. Esa es la razón por la que el entorno de datos se activa **por sesión de trabajo** y no de forma continua.

## Metodología

Metodología ágil con tablero **Kanban en GitHub Projects**, trabajo por ramas en GitHub, tres fases con entregables definidos y un responsable asignado por hito.

## Cronograma de Actividades

Duración total: **13 semanas** (inicio: semana del 10 de agosto de 2026).

| Fase | Semanas | Fechas |
|---|---|---|
| **Fase 1** — Planificación | S1 – S4 | 10-ago a 06-sep |
| **Fase 2** — Desarrollo y pruebas | S5 – S11 | 07-sep a 25-oct |
| **Fase 3** — Cierre y defensa | S12 – S13 | 26-oct a 08-nov |

### Carta Gantt

| Actividad | Fase | Semanas | Fechas |
|---|---|---|---|
| Planificación del proyecto | Fase 1 | S1 – S4 | 10-ago a 06-sep |
| Coordinación con el colegio | Fase 1–2 | S3 – S5 | 24-ago a 13-sep |
| Diseño e implementación VR | Fase 2 | S5 – S9 | 07-sep a 11-oct |
| Arquitectura de datos | Fase 2 | S5 – S8 | 07-sep a 04-oct |
| Consentimientos informados | Fase 2 | S5 – S6 | 07-sep a 20-sep |
| Pruebas de campo | Fase 2 | S8 – S11 | 28-sep a 25-oct |
| Transmisión de datos a AWS | Fase 2 | S10 – S11 | 12-oct a 25-oct |
| Cierre y defensa final | Fase 3 | S12 – S13 | 26-oct a 08-nov |

```
Actividad                      | F1: S1 S2 S3 S4 | F2: S5 S6 S7 S8 S9 S10 S11 | F3: S12 S13
-------------------------------|-----------------|----------------------------|------------
Planificación del proyecto     |     ██ ██ ██ ██ |                            |
Coordinación con el colegio    |           ██ ██ |     ██                     |
Diseño e implementación VR     |                 |     ██ ██ ██ ██ ██         |
Arquitectura de datos          |                 |     ██ ██ ██ ██            |
Consentimientos informados     |                 |     ██ ██                  |
Pruebas de campo               |                 |           ██ ██ ██  ██     |
Transmisión de datos a AWS     |                 |                 ██  ██     |
Cierre y defensa final         |                 |                            |  ██  ██
```

## Hitos del Proyecto

| # | Hito | Estado |
|---|---|---|
| 1 | Diseño de la experiencia definido (escenarios, recorrido, gamificación, paleta) | En curso |
| 2 | Arquitectura de datos definida y documentada | Completado |
| 3 | Cuentas y servicios en AWS operativos, listos para el acople del equipo de IA | En curso |
| 4 | Documentación formal (Acta de Constitución, Especificación de Requerimientos) | Completado |
| 5 | Tablero Kanban con el avance por fase | Completado |

## Equipo

- Constanza Quiero
- Katalina Pérez
- Kathleen Ampuero

## Estructura de Carpetas

```
Fase 1/
├── Evidencias Grupales/
│   ├── 1.4_APT122_FormativaFase1.docx                                          → Informe Técnico de Definición de Proyecto APT
│   ├── 1.5_GuiaEstudiante_Fase 1_Definicion Proyecto APT (Español).docx        → Guía de Definición de Proyecto APT, versión en español
│   ├── 1.5_GuiaEstudiante_Fase 1_Definicion Proyecto APT (Inglés).docx         → Guía de Definición de Proyecto APT, versión en inglés
│   └── Presentación Proyecto.pptx                                              → Pitch / presentación del proyecto
│
└── Evidencias Individuales/
    ├── Kathleen Ampuero  (1.1 Autoevaluación de Competencias, 1.2 Diario de Reflexión, 1.3 Autoevaluación Fase 1)
    ├── Katalina Pérez    (1.1 Autoevaluación de Competencias, 1.2 Diario de Reflexión, 1.3 Autoevaluación Fase 1)
    └── Constanza Quiero  (1.1 Autoevaluación de Competencias, 1.2 Diario de Reflexión, 1.3 Autoevaluación Fase 1)

Fase 2/
└── Evidencias Proyecto/
```
