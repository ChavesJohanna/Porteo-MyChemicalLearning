
# My Chemical Learning

**Cátedra:** Diseño según plataforma de juegos  
**Grupo:** Kojibara Studios

## Integrantes

- Goitea Mateo Nicolás
- Chaves Johanna Milagro
- Acosta Ledesma, Martín Sebastián
- Tarifa, Juan Mateo
- Flores Ruiz, Ruben Claudio

## Ficha del juego

### Información general

| Campo | Descripción |
|---|---|
| **Título** | My Chemical Learning |
| **Género** | Plataformas 2D, educativo |
| **Plataforma actual** | Dispositivos móviles (Android) |
| **Plataforma objetivo** | PC (Windows) |
| **Repositorio** | [Porteo-MyChemicalLearning](https://github.com/ChavesJohanna/Porteo-MyChemicalLearning) |

### Descripción

En *My Chemical Learning*, el jugador controla a V.E.G.A., una inteligencia artificial construida para aprender química. Debe avanzar por las plataformas, combinar elementos y utilizarlos para eliminar obstáculos y superar desafíos.

El jugador gana al completar los elementos requeridos y atravesar el nivel hasta llegar a la meta. Pierde cuando se queda sin vida o cae al vacío.

### Mecánica principal y ciclo de juego

El ciclo principal de juego consiste en:

**Moverse → Saltar → Interactuar → Combinar elementos → Disparar → Llegar a la meta**

### Contenido y duración

- **Contenido:** menú principal, menú de opciones básico, un nivel introductorio y escenas de victoria y derrota.
- **Duración estimada:** ~5 minutos.

### Controles actuales (Android)

El juego utiliza un joypad táctil en pantalla.

| Control | Acción |
|---|---|
| Flechas izquierda y derecha | Movimiento lateral |
| Flecha arriba | Saltar |
| Botón de disparo | Usar el elemento seleccionado |
| Botón de interacción | Interactuar con objetos del mundo |
| Inventario | Consultar la lista completa de elementos conseguidos |
| Slots 1-3 | Acceso rápido a elementos seleccionados |

### Controles propuestos para PC

Los siguientes controles corresponden a la propuesta de porteo a Windows.

| Tecla | Acción |
|---|---|
| A y D | Movimiento lateral |
| Espacio | Saltar |
| TAB | Abrir inventario |
| J | Disparar |
| E | Interactuar |
| 1, 2 y 3 | Seleccionar elementos mediante los slots |

### Pantalla

| Característica | Configuración |
|---|---|
| Resolución de referencia | 1920x1080 |
| Relación de aspecto indicada | 16:9 |
| Orientación | Horizontal |
| Modo de visualización | Pantalla completa |

### Estado del proyecto

Los siguientes estados indican el nivel de implementación o verificación de las funcionalidades.

| Funcionalidad | Estado |
|---|---|
| Rendimiento de 30 FPS en dispositivos móviles | **VERIFICADO** |
| Botones funcionales del menú principal | **VERIFICADO** |
| Opciones del menú de opciones | **APLICADO** |
| Controles de movimiento funcionales | **VERIFICADO** |
| Disparo de elementos | **VERIFICADO** |
| Uso del inventario y slots | **VERIFICADO** |
| Interacción con la mesa de trabajo | **VERIFICADO** |
| Interacción con enemigos y cálculo de daño | **VERIFICADO** |
| Menú de pausa funcional | **VERIFICADO** |
| Carga de checkpoints al perder | **VERIFICADO** |
| Pantalla de derrota funcional | **VERIFICADO** |
| Pantalla de victoria funcional | **VERIFICADO** |
| Nuevo mapa para el nivel 2 | **PROPUESTO** |
| Nuevas habilidades para el nivel 2 | **PROPUESTO** |
| Nuevos enemigos para el nivel 2 | **PROPUESTO** |
| Transición del nivel 1 al nivel 2 | **PROPUESTO** |
| Rendimiento de 60 FPS en PC | **UNKNOWN** |
| Escalado de resolución en PC sin problemas | **UNKNOWN** |

### Versión del motor

- **Motor:** Unity.
- **Versión exacta:** `6000.3.11f1`
- **Plataforma actual:** Android
- **Plataforma objetivo:** Windows (PC)

## Cómo abrir y jugar

### Abrir el proyecto en Unity

1. Clonar o descargar el repositorio
2. Abrir Unity Hub
3. Seleccionar la opción para añadir un proyecto desde el disco
4. Elegir la carpeta raíz del proyecto, donde se encuentran `Assets` y `ProjectSettings`
5. Abrir el proyecto con Unity `6000.3.11f1`
6. Abrir la escena principal del juego
7. Presionar **Play** para ejecutar el juego dentro del Editor

### Ejecutar la versión para Windows

1. Abrir la carpeta de la compilació
2. Ejecutar `MyChemicalLearning.exe`.
3. Mantener los archivos asociados en sus ubicaciones originales

## Créditos y licencias de los assets

| Recurso | Autor | Licencia |
|---|---|---|
| Modelos y sprites | Goitea Mateo Nicolás | Producción propia. Todos los derechos reservados. |
| Música | Acosta Ledesma, Martín Sebastián | Producción propia. Todos los derechos reservados. |
| Efectos de sonido | Tarifa, Juan Mateo | Producción propia. Todos los derechos reservados. |

## Estado general

Proyecto en desarrollo. La versión móvil cuenta con las funcionalidades verificadas en la tabla de estado. El porteo a PC contempla la adaptación de los controles, la interfaz y las pruebas de rendimiento y resolución.
