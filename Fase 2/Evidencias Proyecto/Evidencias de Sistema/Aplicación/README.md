# Aplicación: EmotionLAB para Meta Quest

- **Build instalable:** `../EmotionLab.apk` (versión v0.1.0, guardada con Git LFS en la carpeta *Evidencias de Sistema*).
- **Código fuente propio:** `Codigo Unity/`, con los scripts en C# del equipo:
  - `Assets/Resources/My scripts/`: lógica de la experiencia (diálogos, formularios, respiración guiada, interrupciones, cambio de escenas) y `EmotionDataManager.cs`, que guarda las respuestas de la sesión en JSON local y las envía a la API.
  - `Assets/AssetsRelajacion/scripts/` y `Assets/FuncionalPato.cs`: minijuego de cierre (recolección de patitos).
  - `Assets/EmotionLab/Scripts/`: utilidades de navegación entre escenas.
- **Proyecto Unity completo** (escenas, assets e historial de commits): https://github.com/KatalinaPerez/EmotionLab
- **Configuración del proyecto:** carpetas `Packages/` y `ProjectSettings/` en la raíz de este repositorio (Unity 2022.3.62f2, URP, XR para Meta Quest).
