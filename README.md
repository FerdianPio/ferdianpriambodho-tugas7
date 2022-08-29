# FerdianPriambodho-Tugas7

1. Load untuk object yang tidak diperlukan dapat dikurangi dengan tidak me-load file sigleton yang tidak digunakan dalam scene.
2. Beban load multiple sprite dalam satu scene dapat dikurangi dengan penggunaan sprite atlas agar sprite-sprite yang digunakan dapat di load sekali dengan load file atlas tersebut.
3. Untuk object spawner dapat diterapkan sistem pooling untuk meningkatkan performa dibandingkan dengan membuat file baru setiap object spawn tersebut diperlukan
4. Load multiple object yang identik dapat diatasi dengan static batching yang secara konsepsional object yang identik tersebut akan dilakukan merge pada object dengan material yang sama. Optimasi ini perlu dilakukan untuk mengurangi draw call dalam scene.