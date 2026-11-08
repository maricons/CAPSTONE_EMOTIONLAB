# EmotionLAB

Proyecto Capstone — Ingeniería en Informática, Duoc UC (sede Viña del Mar).

Repositorio de entrega: https://github.com/maricons/CAPSTONE_EMOTIONLAB

Repositorio de desarrollo (proyecto Unity completo e historial): https://github.com/KatalinaPerez/EmotionLab

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

**EmotionLAB es un proyecto de continuidad** del CITT de Duoc UC. Existe una versión previa orientada a estudiantes de **educación superior**. Esta fase la reorienta a **estudiantes de Enseñanza Media (adolescentes)** e incorpora **gamificación** en la experiencia.

El proyecto se desarrolla en la asignatura Capstone, con pruebas de campo en dos establecimientos de la Región de Valparaíso: el **Liceo Comercial de Quilpué** y el **Colegio Liahona**.

Somos el **equipo de desarrollo y diseño de la aplicación** y las responsables de la **telemetría**: la captura de los datos comportamentales durante la experiencia y su transmisión hacia la nube mediante API.

| Equipo | Responsabilidad |
|---|---|
| **Nuestro equipo** | **Desarrollo y diseño de la aplicación**: la experiencia de realidad virtual completa (escenarios, recorrido, gamificación e identidad visual), más la **telemetría**: captura y transmisión de los datos comportamentales hacia la nube mediante API. |
| **Equipo de IA** | **Modelo, clasificación y dashboard**: procesa los datos, los clasifica y genera los insights que se presentan al docente o psicopedagogo. |

## El problema

Existe un **déficit de gestión emocional** en adolescentes frente a situaciones de alta exigencia, como una **exposición oral o una entrevista**. En el aula, la única forma de practicar es exponerse frente al curso completo.

Además, el docente o psicopedagogo no cuenta con **evidencia comportamental** que le permita identificar quién necesita apoyo y en qué momento: la regulación emocional se evalúa por percepción.

## Propuesta de valor

> EmotionLAB **no convierte la emoción en información**. Convierte los **datos comportamentales** en datos útiles para la toma de decisiones del profesor o psicopedagogo.

Es una **herramienta complementaria**: sitúa al estudiante en una situación de exigencia y, a partir de los datos registrados durante el recorrido, permite clasificar si **regula o no regula** sus emociones en esa situación. No es un diagnóstico clínico ni reemplaza el trabajo del docente.

### El recorrido

1. **Sala de espera**: el estudiante elige el tema de su presentación y responde el formulario inicial sobre cómo se siente.
2. **Oficina (modo fácil)**: presentación ante una sola persona, con respiración guiada previa e interrupciones como ruido y la falla simulada del computador.
3. **Salón (modo difícil)**: presentación ante más público y con más distracciones, también con respiración guiada previa.
4. **Retroalimentación**: respiración guiada y formulario final, que permite comparar el estado emocional del inicio y del final.
5. **Cierre**: minijuego de recolección de patitos en una sala *cozy*, como descompresión positiva.

Todo el recorrido queda registrado de forma **anónima**: ningún dato identifica a un estudiante y cada apoderado autoriza la participación mediante consentimiento informado.

## Estado del proyecto

| Componente | Estado |
|---|---|
| Experiencia VR (APK v0.1.0, recorrido completo) | ✅ Completado |
| Infraestructura AWS con Terraform | ✅ Completado |
| Pruebas de campo (desde el 5 de octubre) | 🟡 En curso: 27 registros de estudiantes |
| Informe final (2.6, español e inglés) | ✅ Completado |
| Evaluación formativa con el docente | 🟡 9 de noviembre |
| Defensa ante la comisión | 🟡 14 de noviembre |

### Resultados

| Métrica | Meta | Resultado |
|---|---|---|
| PI-01 Integración: POST → JSON en S3 | 200 OK | ✅ Exitosa |
| PU-01 Unitaria: payload sin id | 400 Bad Request | ✅ Exitosa |
| RNF-008 Privacidad | 0 datos identificatorios | ✅ Cumple por diseño |
| Cobertura de pruebas de campo (OE3) | ≥ 20 estudiantes | ✅ 27 registros |
| RNF-010 Duración de sesión | 10 a 15 min | ≈ 20 min promedio |
| RNF-009 Usabilidad | ≥ 90 % sin asistencia | La mayoría requirió asistencia |
| RNF-001 Rendimiento | ≥ 72 FPS | En medición |

**Hallazgos en terreno:** a los estudiantes les cuesta encontrar los formularios de inicio y cierre y el botón «Siguiente» de las láminas, y ante la falla simulada del PC se quedan quietos sin saber qué hacer. La respiración guiada funciona sin ayuda. Estos hallazgos forman el backlog de usabilidad: señalización visual y un tutorial inicial.

## Tecnologías

| Área | Herramientas |
|---|---|
| Experiencia VR | **Unity 2022.3** (URP) · C# · **visores Meta Quest** (standalone) |
| Nube y datos | **Amazon API Gateway** · **AWS Lambda** (Python) · **Amazon S3** · **IAM** |
| Infraestructura | **Terraform** (infraestructura como código) · **AWS Academy Learner Lab** |
| Gestión y versiones | **GitHub** (ramas y pull requests) · **GitHub Projects** (Kanban) · **Git LFS** (APK) |

## Arquitectura de datos

La arquitectura es **serverless** y está descrita íntegramente como código con Terraform.

![Arquitectura EmotionLAB](Fase%202/Evidencias%20Proyecto/Evidencias%20de%20Sistema/Arquitectura%20EmotionLab%20Desarrollo.jpeg)

```
  Meta Quest (app Unity)   guarda la sesión en JSON local
          │  HTTPS / JSON
          ▼
  Amazon API Gateway       puerta de entrada única
          ▼
  AWS Lambda (IAM)         crear · obtener · modificar JSON
          ▼
  Amazon S3                sesiones en JSON
          ▼
  Equipo de IA             modelo de clasificación y dashboard
```

### Decisiones de diseño

- **Serverless en vez de un servidor tradicional.** No hay infraestructura encendida de forma permanente ni sistema operativo que parchear; se paga por invocación.
- **S3 en lugar de una base de datos relacional.** Los datos son semiestructurados (JSON por sesión) y no requieren joins.
- **API Gateway como puerta de entrada única.** La app nunca conoce el bucket ni las funciones; un dashboard web puede consumir la misma API sin cambios.
- **Guardado local primero.** Cada sesión se guarda como JSON en el visor y luego se sincroniza con S3, para no perder datos si el entorno de AWS no está activo.
- **Infraestructura como código con Terraform.** Todo el entorno se recrea con un comando. Se probó en un caso real: el **29 de octubre** se perdió el acceso a la cuenta de AWS y la arquitectura se recreó en una cuenta nueva en pocos minutos. Los JSON de la cuenta anterior no se pudieron rescatar, por lo que se incorpora el respaldo periódico fuera de AWS.

### Modelo de datos

```json
{
  "idParticipante": "participante_20260930_220039_c947b9ff",
  "fechaInicio": "2026-09-30 22:00:39",
  "fechaFin": "2026-09-30 22:15:38",
  "difficulty_level": "dificil",
  "facilCompletado": true,
  "dificilCompletado": true,
  "respuestas": [
    { "escena": "waiting_room_inicial", "idPregunta": "edad", "respuestaLabel": "+17", "timestamp": "2026-09-30 22:02:16.359" }
  ]
}
```

Identificador anónimo y edad elegida de una lista, sin fecha de nacimiento; no se almacena nombre, RUT ni correo.

El formulario inicial pregunta la edad y, en una escala de 9 caritas que van del verde al rojo: ¿Cómo te sientes hoy?, ¿Te sientes nervioso?, ¿Te sientes preocupado? y ¿Te sientes preparado? El formulario final de la retroalimentación vuelve a registrar el estado emocional para comparar el inicio con el final.

## Documentación técnica

Disponible en `Fase 2/Evidencias Proyecto/Evidencias de documentación/`:

| Documento | Contenido |
|---|---|
| `ERS_EmotionLab.docx` | Especificación de Requerimientos v2.0 (RF y RNF verificables) |
| `Documento_Diseno_EmotionLab.docx` | Arquitectura, modelo de datos, UML (casos de uso, componentes, secuencia y clases), decisiones técnicas y despliegue |
| `Gestion_Agil_EmotionLab.docx` | Product Vision, Product Backlog, tablero, Definition of Done, fichas de ciclo y retrospectivas |
| `Product_Backlog_EmotionLab.xlsx` | Historias de usuario con criterios de aceptación |
| `Plan_Pruebas_EmotionLab.docx` | Pruebas unitarias, de integración, rendimiento, seguridad y de campo |
| `Matriz_Trazabilidad_EmotionLab.xlsx` | Requisito → historia → caso de uso → componente → prueba → evidencia |
| `Manual_Tecnico_EmotionLab.docx` | Requisitos, despliegue con Terraform, compilación, instalación y solución de problemas |
| `Cierre_Innovacion_EmotionLab.docx` | Innovación, resumen de ciclos, mejoras aplicadas y estado final |

### Inicio rápido

1. **Nube:** iniciar AWS Academy Learner Lab, exportar las credenciales temporales y ejecutar `terraform init` y `terraform apply`.
2. **App:** abrir el [repositorio de desarrollo](https://github.com/KatalinaPerez/EmotionLab) con Unity 2022.3.62f2, configurar `apiUrl` en `EmotionDataManager` con la URL que entrega Terraform y compilar para Android, o instalar directamente `EmotionLab.apk` con `adb install -r EmotionLab.apk`.
3. **Probar:** completar el recorrido en el visor y verificar el JSON en la carpeta de la fecha del bucket S3.

El detalle está en el Manual Técnico.

## Metodología

Metodología ágil **Kanban en GitHub Projects** (Backlog → To do → In progress → Done), con revisión semanal del tablero, issues con sub-issues por hito y trabajo por ramas con pull requests.

**Definition of Done:** una tarea pasa a *Done* cuando (1) está integrada en la rama principal, (2) fue verificada en su entorno (visor Meta Quest o envío de un JSON real a S3) y (3) su documentación o diagrama está actualizado. Cada ciclo cierra con una retrospectiva *Keep / Stop / Start*.

## Cronograma

Duración total: **13 semanas** (inicio: semana del 10 de agosto de 2026).

| Actividad | Semanas | Estado |
|---|---|---|
| Planificación y documentación | S1 – S4 | ✅ Completado |
| Coordinación con colegios | S3 – S7 | ✅ Completado |
| Diseño e implementación VR | S5 – S9 | ✅ Completado |
| Arquitectura de datos (AWS + Terraform) | S5 – S8 | ✅ Completado |
| Consentimientos informados | S5 – S7 | ✅ Completado |
| Pruebas de campo | S9 – S13 | 🟡 En curso (desde el 5 de octubre) |
| Transmisión de datos a AWS | S10 – S13 | 🟡 En curso |
| Cierre y defensa final | S12 – S13 | 🟡 En curso |

Las pruebas de campo se extendieron a la Fase 3 por la confirmación tardía de los colegios.

## Hitos del proyecto

| # | Hito | Estado |
|---|---|---|
| 1 | Documentación formal (Acta de Constitución, ERS v2.0) | ✅ Completado |
| 2 | Diseño de la experiencia (escenarios, recorrido, gamificación, identidad visual) | ✅ Completado |
| 3 | Prototipo funcional VR: APK v0.1.0 | ✅ Completado |
| 4 | Arquitectura de datos definida, desplegada y documentada | ✅ Completado |
| 5 | Servicios AWS operativos para el acople del equipo de IA | ✅ Completado |
| 6 | Tablero Kanban con el avance por fase | ✅ Completado |
| 7 | Pruebas de campo en dos establecimientos | 🟡 En curso |

## Equipo

| Integrante | Rol principal |
|---|---|
| Constanza Quiero | Documentación formal y gestión de assets del entorno VR |
| Katalina Pérez | Infraestructura en AWS con Terraform e integración de la API |
| Kathleen Ampuero | Pruebas funcionales, corrección de errores y builds APK |

Las tres participamos en el desarrollo, las pruebas y el versionamiento del proyecto.

## Proyecto Unity

La configuración del proyecto está en `Packages/` y `ProjectSettings/` (Unity **2022.3.62f2**, URP, XR para Meta Quest). Para abrirlo: clonar el repositorio, agregarlo desde Unity Hub con esa versión del editor y compilar para Android (Meta Quest). La build lista para instalar está en `Fase 2/Evidencias Proyecto/Evidencias de Sistema/EmotionLab.apk`.

El proyecto Unity completo (escenas, assets y scripts), con todo su historial de commits, vive en el [repositorio de desarrollo](https://github.com/KatalinaPerez/EmotionLab). En este repositorio se respaldan los scripts propios en C# en `Fase 2/Evidencias Proyecto/Evidencias de Sistema/Aplicación/Codigo Unity/`; por ejemplo, `EmotionDataManager.cs` gestiona las respuestas de la sesión y su envío a la API.

## Estructura de carpetas

Estructura oficial de entregables de la asignatura (✅ entregado · 🟡 pendiente · *Opt.* = optativo).

```
Fase 1/
├── Evidencias Individuales/
│   ├── Apellido_Nombre_1.1_APT122_AutoevaluacionCompetenciasFase1.docx      ✅ ×3
│   ├── Apellido_Nombre_1.2_APT122_DiarioReflexionFase1.docx                 ✅ ×3
│   └── Apellido_Nombre_1.3_APT122_AutoevaluacionFase1.docx                  ✅ ×3
└── Evidencias Grupales/
    ├── Presentación Proyecto.pptx                                           ✅
    ├── 1.4_APT122_FormativaFase1.docx                                       ✅
    ├── 1.5_GuiaEstudiante_Fase 1_Definicion Proyecto APT (Español).docx     ✅
    ├── 1.5_GuiaEstudiante_Fase 1_Definicion Proyecto APT (Inglés).docx      ✅ Opt.
    └── PLANILLA DE EVALUACIÓN FASE 1.xlsx                                   ✅

Fase 2/
├── Evidencias Individuales/
│   └── Apellido_Nombre_2.1_APT122_DiarioReflexionFase2.docx                 ✅ ×3 (más 2.2 Autoevaluación)
├── Evidencias Grupales/
│   ├── 2.4_GuiaEstudiante_Fase 2_DesarrolloProyecto APT (Español).docx      ✅
│   ├── 2.4_GuiaEstudiante_Fase 2_DesarrolloProyecto APT (Inglés).docx       ✅ Opt.
│   ├── PLANILLA DE EVALUACION AVANCE FASE 2.xlsx                            ✅
│   ├── 2.6_GuiaEstudiante_Fase 2_Informe Final Proyecto APT (Español).docx  ✅
│   ├── 2.6_GuiaEstudiante_Fase 2_Informe Final Proyecto APT (Inglés).docx   ✅ Opt.
│   └── PLANILLA DE EVALUACION FINAL FASE 2.xlsx                             ✅
└── Evidencias Proyecto/
    ├── Presentación Proyecto.pptx                                           ✅
    ├── Evidencias de documentación/                                         ✅ Acta, ERS, diseño, gestión ágil, pruebas,
    │   │                                                                       trazabilidad, manual técnico, cierre e innovación,
    │   │                                                                       protocolo, apoderados, consentimiento y storyboard
    │   └── Presentaciones - Ensayo EmotionLab/                              ✅ Presentaciones CITT, ensayo y paper
    └── Evidencias de Sistema/
        ├── EmotionLab.apk                                                   ✅ Build v0.1.0 (Git LFS)
        ├── Arquitectura *.jpeg / *.jpg                                      ✅ Diagramas de arquitectura
        ├── Aplicación/                                                      ✅ Código C# propio (Codigo Unity/)
        └── Base de datos/                                                   ✅ Modelo de datos JSON y decisiones

Fase 3/
├── Evidencias Individuales/
│   ├── Quiero_Constanza_3.1_APT122_DiarioReflexionFase3.docx                ✅
│   ├── Perez_Katalina_3.1_APT122_DiarioReflexionFase3.docx                  🟡
│   └── Ampuero_Kathleen_3.1_APT122_DiarioReflexionFase3.docx                🟡
└── Evidencias Grupales/
    ├── PLANILLA DE EVALUACIÓN FASE 3.xlsx                                   🟡 (enviada por correo)
    ├── Presentación Final del proyecto (Español).pptx                       🟡 (comisión 14-nov)
    └── Presentación Final del proyecto (Inglés).pptx                        Opt.

Packages/  ProjectSettings/                                                  → Configuración del proyecto Unity
```
