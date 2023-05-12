using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Conceptos : MonoBehaviour
{
    public Sprite imagen;
    public GameObject canva;
    public int boton;
    public TextMeshProUGUI textoTitulo;
    public TextMeshProUGUI textoCuerpo;

    // Muestra imagen en canva
    public void CambiarImagen()
    {
        canva.GetComponent<Image>().sprite = imagen;
        texto();
    }

    public void texto()
    {
        switch (boton)
        {
            case 0:
                textoTitulo.text = "Abstracto";
                textoCuerpo.text = "Término que se aplica a un movimiento de la pintura estadounidense que tuvo lugar entre la década de los cuarenta y la de los cincuenta. En ocasiones se denomina “escuela de Nueva York” o, en un sentido más limitado, “action painting”, aunque se acuñó por primera vez en referencia a la obra de Vasili Kandinsky en 1929. Aunque inicialmente el término designa solo a un pequeño núcleo de artistas, las características del expresionismo abstracto pueden reconocerse también en las esculturas de David Smith e Ibram Lassaw, entre otros, en las fotografías de Aaron Siskind o en la pintura de Mark Tobey, así como en las obras de artistas de menor renombre, como Bradley Walker Tomlin y Lee Krasner.";
                break;
            case 1:
                textoTitulo.text = "Barroco";
                textoCuerpo.text = "El Barroco es la principal tendencia europea en las artes plásticas durante el siglo XVII y la primera mitad del XVIII. Generalmente, se le conoce como el periodo de Caravaggio, Rubens, Rembrandt, Giordano y Tiepolo en pintura, Bernini en escultura, y Borromini, Fischer von Erlach y Wren en arquitectura. El uso de este término a menudo abarca el periodo completo desde 1600 hasta 1750 sin unas restricciones claras. También, puede referirse incorrectamente al estilo florido y muy recargado representado en el arte, en la arquitectura, en la música o en la literatura de cualquier fecha desde la antigüedad tardía hasta principios del siglo XX.";
                break;
            case 2:
                textoTitulo.text = "Cinetismo";
                textoCuerpo.text = "Término que se aplica a las obras de arte relacionadas con un movimiento real y aparente. Puede incluir máquinas, estructuras móviles y objetos ligeros en movimiento. De manera más generalizada, también incluye obras cuyo movimiento sea virtual o aparente, que pueden englobarse en la denominación “arte óptico” El arte cinético se originó entre 1913 y 1920, cuando algunos artistas aislados, como Marcel Duchamp, Vladimir Tatlin y Naum Gabo, hicieron hincapié en sus primeras obras y escritos, en la idea de emplear el movimiento mecánico.";
                break;
            case 3:
                textoTitulo.text = "Conceptual";
                textoCuerpo.text = "Es el término para designar las obras creadas desde mediados de los sesenta que restaron una notable importancia o incluso eliminaron por completo la representación perceptiva de objetos únicos para hacer prevalecer las ideas. Asimismo, el arte conceptual impulsó el inicio de las instalaciones multimedia que tuvieron un gran auge a partir de los ochenta.";
                break;
            case 4:
                textoTitulo.text = "Constructivismo";
                textoCuerpo.text = "Tendencia vanguardista de la pintura, la escultura, la fotografía, el diseño y la arquitectura del siglo XX, con actividades paralelas relacionadas en la literatura, el teatro y el cine. Los artistas rusos fueron los primeros en usar este término, a principios de 1921, y se extendió por todo el mundo durante la década de los veinte. Los constructivistas internacionales se inspiraban en los modelos rusos, tanto en los aspectos artísticos como en los políticos. Aunque emplearon las técnicas artísticas tradicionales en la pintura y en la escultura, experimentaron con el cine y la fotografía y reconocieron el potencial del nuevo lenguaje formal para el diseño utilitarista.";
                break;
            case 5:
                textoTitulo.text = "Contemporáneo";
                textoCuerpo.text = "El arte contemporáneo es el arte de nuestro tiempo, que refleja o guarda relación con la sociedad actual. El arte contemporáneo suele referirse a obras originadas a partir de la mitad del siglo XX. La palabra contemporáneo engloba un conjunto muy heterogéneo de prácticas cuya asignación a la contemporaneidad es caduca por definición. Diversos autores han abordado esta problemática, ahondando a menudo en la diferencia con el Arte moderno y su acotación histórica. En otras disciplinas, esta adjetivación es singular: literatura moderna y literatura contemporánea denotan significados diferentes. De manera mucho más clara, el concepto de música moderna suele reservarse para la música popular moderna; mientras que el de música contemporánea se hace para el de la música académica del siglo XX —aunque también es común encontrar publicaciones e instituciones que asimilan ambas denominaciones y que hablan de 'arte moderno y contemporáneo'.";
                break;
            case 6:
                textoTitulo.text = "Cubismo";
                textoCuerpo.text = "Término derivado de los cubos y diagramas geométricos que menciona el crítico Louis Vauxcelles en la descripción de las pinturas expuestas en París por Georges Braque en noviembre de 1908. Se aplica, por lo general, no solo a las obras de este periodo realizadas por Braque y Pablo Picasso, sino también a una gama de trabajos artísticos elaborados en Francia durante la época final de la década de 1900, la de 1910 y la de 1920, así como a las que se llevaron a cabo en otros países.";
                break;
            case 7:
                textoTitulo.text = "Expresionismo";
                textoCuerpo.text = "El expresionismo fue un movimiento artístico y arquitectónico internacional que prosperó entre 1905 y 1920, particularmente en Alemania. También se extendió a los campos de la literatura, la música, la danza y el teatro. En principio, este término se usó más para hablar sobre varios movimientos vanguardistas, por ejemplo, como sustituto del concepto de “Posimpresionismo” de Roger Fry en las exposiciones de Londres en 1910 y 1912. En Escandinavia y Alemania, se usó simultáneamente, mientras se limitaba gradualmente a los grupos de artistas y arquitectos específicos a los que se aplica actualmente. El expresionismo en las bellas artes se desarrolló a partir de las tendencias simbolistas y expresivas del arte europeo a finales del siglo XIX";
                break;
            case 8:
                textoTitulo.text = "Futurimos";
                textoCuerpo.text = "Movimiento italiano que surgió como una corriente literaria y evolucionó hasta abarcar la pintura, la escultura, la fotografía y la arquitectura. El punto de arranque del futurismo se sitúa en la publicación, el 20 de febrero de 1909, del Manifiesto futurista por Filippo Tommaso Marinetti en el periódico parisino Le Figaro. La intención de Marinetti no era otra que la de rechazar el pasado, revolucionar la cultura y modernizarla. La nueva ideología del futurismo se enfrentaba con un entusiasmo casi agresivo a la onerosa herencia de un arte asociado a la tradición cultural italiana y enaltecía la idea de una estética generada por el mito moderno de las máquinas y la velocidad.";
                break;
            case 9:
                textoTitulo.text = "Gótico";
                textoCuerpo.text = "El término gótico es una denominación de los estilos artísticos y arquitectónicos occidentales, que se desarrollaron desde mediados del siglo XII hasta el XV en Italia, o hasta el XVI en otros lugares. Vasari fue el primero que usó este concepto para describir la arquitectura prerrenacentista, después de que los escritores humanistas hubieran asociado la arquitectura anterior a Brunelleschi con bárbaros o alemanes. A partir del siglo XVIII, cuando los anticuarios establecieron el estilo románico, el arte gótico abarca los siglos que transcurren entre el periodo románico y el Renacimiento.";
                break;
            case 10:
                textoTitulo.text = "Griego";
                textoCuerpo.text = "El Arte Griego en la antigüedad tiene como característica fundamental tener un alto idealismo estético, lo cual implica que el arte representa no la realidad cruda y directa sino una visión idílica y perfecta que se percibe por el uso de la proporcionalidad y equilibrio de los elementos así como por su interés en reflejar en las obras artísticas las líneas de la figura humana a la perfección; tanto en el dibujo como en la escultura. El cuerpo humano para ellos es el fundamento esencial de toda belleza y toda proporción, A esta tendencia se le denomina Antropocentrismo.";
                break;
            case 11:
                textoTitulo.text = "Informalismo";
                textoCuerpo.text = "El informalismo es un movimiento artístico que abarca todas las tendencias abstractas y gestuales que se desarrollaron en Francia, España e Italia durante la segunda posguerra mundial, en paralelo con el expresionismo abstracto estadounidense. El movimiento fue bautizado por Juan Eduardo Cirlot, quien fue su principal ideólogo. Dentro de él se distinguen diferentes corrientes, como la abstracción lírica, la pintura matérica, la Nueva escuela de París, el tachismo, el espacialismo o el art brut.";
                break;
            case 12:
                textoTitulo.text = "Mesopotámico";
                textoCuerpo.text = "Las antiguas civilizaciones de Mesopotamia son la fuente de las primeras formas de arte que han sobrevivido hasta nuestros días. Estas civilizaciones, estaban situadas entre el río Tigris y el río Eufrates. Data del año 3500 a.C. el arte mesopotámico trata de servir como medio para glorificar a los poderosos dirigentes y su conexión con lo divino, de manera similar al arte egipcio. El arte se realizaba a base de los recursos naturales de los que se disponía tales como piedras conchas, mármol y alabastro. No hay datos sobre los nombres de los artistas porque las piezas estaban pensadas para ensalzar el tema del que se trataban y no al creador. Los artículos u obras populares que caracterizan este periodo son, sellos cilíndricos, estelas, esculturas en relieve y tumbas ricamente decoradas.";
                break;
            case 13:
                textoTitulo.text = "Metafísico";
                textoCuerpo.text = "Término aplicado a las obras elaboradas por Giorgio de Chirico y Carlo Carrà antes y después de la Primera Guerra Mundial y, consecuentemente, a las obras producidas por los artistas italianos que se agruparon en torno a ellos. La “pittura metafidica”, como se denominó en italiano, se caracterizaba por recurrir a una iconografía reconocible: se creaba un espacio imaginario en la imagen, basado en una perspectiva de ilusionismo desde un único punto, pero trastornado intencionadamente. En las obras de Giorgio de Chirico, estos factores daban lugar a plazas de ciudades de una profundidad sobrecogedora, rodeadas de galerías con arcadas que se alejan y muros de ladrillo en la distancia, o interiores claustrofóbicos con suelos vertiginosamente empinados.";
                break;
            case 14:
                textoTitulo.text = "Muralismo";
                textoCuerpo.text = "El muralismo fue un movimiento artístico iniciado en México a principios del siglo XX, creado por un grupo de pintores intelectuales mexicanos después de la Revolución Mexicana, reforzado por la Gran Depresión y la Primera Guerra Mundial. El deseo por una verdadera transformación aumentó y se comenzaron a hacer demandas más radicales, que buscaban una revolución social, política y económica. Los mestizos, la clase media y baja se unieron contra Porfirio Díaz.";
                break;
            case 15:
                textoTitulo.text = "Neolítico";
                textoCuerpo.text = "El neolítico es el último de los periodos en que se considera dividida la Edad de Piedra.  Este periodo comenzó entre el 6,000 a.C y el 4,000 a.C, según las diferentes culturas que lo alcanzaron y se extendió hasta el 3000 a.C. El término, que quiere decir «de piedra nueva», se refiere a las elaboradas herramientas de piedra pulida que caracterizan ese período y lo diferencian de la «antigua» Edad de Piedra, o Paleolítico, con herramientas de piedra tallada, más toscas. En la periodización americana, el Neolítico coincide aproximadamente con el Periodo Arcaico.";
                break;
            case 16:
                textoTitulo.text = "Pop";
                textoCuerpo.text = "El término se originó a mediados de la década de 1950 en el ICA de Londres, en los debates mantenidos por el Grupo Independiente sobre los artefactos de la cultura popular. Este pequeño grupo incluía a los artistas Richard Hamilton y Eduardo Paolozzi, así como a arquitectos y críticos. Lawrence Alloway (1926-1990), el crítico que utilizó el término por primera vez en 1958, concibió el arte pop como el extremo inferior de un continuo entre el arte popular y el arte fino, que abarcaba formas como la publicidad, la ilustración de ciencia ficción y el estilo de los automóviles. Hamilton definió el Pop en 1957 como Popular (diseñado para un público masivo); transitorio (solución a corto plazo); prescindible (se olvida fácilmente); de bajo coste; producido en masa; joven (dirigido a la juventud); ingenioso; sexy; artificioso; glamuroso; y gran negocio";
                break;
            case 17:
                textoTitulo.text = "Postmoderno";
                textoCuerpo.text = "Este término se emplea para representar los avances en la arquitectura y en el arte después de los años sesenta, cuando había un claro desafío al dominio del modernismo. Se aplica principalmente a la arquitectura desde los años setenta y, un poco más tarde, al arte decorativo y visual. El escritor español Federico de Onís usó este término por primera vez en 1934, aunque no se volvió a nombrar hasta la publicación de “Un estudio de historia” de Arnold Toynbee en 1938, tras la Segunda Guerra Mundial. Estos escritores consideraban el posmodernismo como un fenómeno bastante negativo que significaba la reacción irracional hacia el racionalismo modernista. A partir de entonces, el término se usó de forma esporádica en los ámbitos de la crítica literaria y de la música.";
                break;
            case 18:
                textoTitulo.text = "Realismo mágico";
                textoCuerpo.text = "El realismo mágico es un estilo pictórico muy conocido en Europa y en EE. UU., principalmente desde los años veinte hasta los años cuarenta, que contó con algunos seguidores durante los años cincuenta. Se sitúa entre el surrealismo y el fotorrealismo, en los que el tema se representa con un naturalismo fotográfico, pero el uso de los tonos lisos, las perspectivas ambiguas y las extrañas yuxtaposiciones sugieren una realidad imaginaria o soñada. El historiador de arte Franz Roh introdujo este término en su libro Nach-Expressionismus: Magischer Realismus (Posexpresionismo: Realismo mágico) de 1925 para describir un estilo procedente de Neue Sachlichkeit (Nueva objetividad), pero que nació de las fantasías románticas alemanas a finales del siglo XIX.";
                break;
            case 19:
                textoTitulo.text = "Renacimiento";
                textoCuerpo.text = "El Renacimiento es el término que generalmente hace referencia a los periodos que retoman la cultura de la antigüedad clásica. Aunque se puede aplicar en muchos campos, se usa frecuentemente para designar una etapa en Europa, que empezó aproximadamente en el siglo XIV, y en la que nació un nuevo estilo de pintura, escultura y arquitectura después del periodo gótico. Desde un punto de vista cultural más amplio, fue un periodo de transición entre la Edad Media y el mundo moderno.";
                break;
            case 20:
                textoTitulo.text = "Romano";
                textoCuerpo.text = "El arte romano, al igual que su arquitectura e ingeniería, se extendió, como su imperio, a lo largo y ancho del perímetro del Mar Mediterráneo, siendo uno de los principales exponentes de la avanzada civilización romana.  El arte romano hunde sus raices en diversas influencias, especialmente del mundo etrusco y del griego. La fuerte organización y personalidad del Imperio Romano exige un arte y una arquitectura que aúne el carácter funcional con el propagandístico. De esta forma nace un arte muy centralizado y unitario que abarca todo el imperio, no sólo Roma sino, en mayor o menor medida, a todas su provincias. No cabe duda que el arte romano es la manifestación artística más significativa de la historia del mundo occidental, ya que su influencia nunca se ha dejado de percibir a lo largo de los muchos siglos desde su desaparición en toda Europa. No ha habido momento histórico (quizás el gótico es el arte y arquitectura más alejada del canon romano) que no haya sufrido en mayor o menor medida su influencia.";
                break;
            case 21:
                textoTitulo.text = "Romanticismo";
                textoCuerpo.text = "Tendencia cultural dominante en el mundo occidental que se desarrolló a finales del siglo XVIII y el XIX. Generó una revaluación de la naturaleza del arte y de la función del artista en la sociedad. De manera significativa, a partir de la década de 1790, se convirtió en un movimiento de autoproclamación, el primero de este tipo, e inició una tradición que se ha mantenido en la cultura occidental desde entonces. La mayoría de los artistas que se han concebido posteriormente como protagonistas de este movimiento lo rechazaban o ignoraban.";
                break;
            case 22:
                textoTitulo.text = "Simbolismo";
                textoCuerpo.text = "El simbolismo fue uno de los movimientos literarios más importantes de finales del siglo XIX. Tiene su origen en Francia y en Bélgica. En un manifiesto literario publicado en 1885, Jean Moréas definió este nuevo estilo como «enemigo de la enseñanza, la declamación, la falsa sensibilidad y la descripción objetiva». Para los simbolistas, el mundo es un misterio por descifrar, y el poeta debe para ello trazar las correspondencias ocultas que unen los objetos sensibles. Para ello es esencial el uso de la sinestesia. El movimiento tiene sus orígenes en Las flores del mal, libro emblema de Charles Baudelaire. El escritor Edgar Allan Poe, a quien Baudelaire apreciaba en gran medida, influyó también decisivamente en el movimiento, proporcionándole la mayoría de imágenes y figuras literarias que utilizaría.";
                break;
            case 23:
                textoTitulo.text = "Suprematismo";
                textoCuerpo.text = "Término acuñado en 1915 por Kazimir Malévich para denominar un nuevo sistema de arte explicado en su libro “Ot kubizma i futurizma k suprematizmu: Novyy zhivopisnyy realizm” (Desde el cubismo y el futurismo al suprematismo: el nuevo realismo pictórico). El término en sí implicaba la supremacía de este nuevo estilo artístico respecto a los anteriores. Malévich lo concebía como algo exclusivamente estético y relacionado únicamente con la forma, carente de significado político o social. Hacía especial hincapié en la pureza de las formas, especialmente del cuadrado, y entendía el suprematismo, básicamente, como una exploración del lenguaje visual, comparable al desarrollo contemporáneo de la escritura.";
                break;
            case 24:
                textoTitulo.text = "Egipcio";
                textoCuerpo.text = "Arte desarrollado en el valle del Nilo, habitado desde el Paleolítico. Su arte, fundamentado en la religión y en sus ideas sobre la vida de ultratumba, en el carácter divino y sagrado del faraón, así como en la influencia del vivir agrario, se caracteriza por el colosalismo y monumentalismo de su arquitectura, por el hieratismo y frontalidad de sus esculturas y por la preponderancia del elemento lineal en su pintura.";
                break;
            case 25:
                textoTitulo.text = "Manierismo";
                textoCuerpo.text = "Es el nombre que recibe la etapa estilística del arte europeo entre el Alto Renacimiento y el Barroco, que se desarrolla aproximadamente desde entre 1510 y 1520 hasta 1600. También se le conoce como Renacimiento Tardío, ya que se aleja claramente del clasicismo del Alto Renacimiento, como se puede observar en las obras tardías de Leonardo da Vinci y Rafael, así como en el arte de Miguel Ángel desde mediados de su carrera creativa. A pesar de que los artistas del siglo XVI tomaron como referencia el vocabulario original del Alto Renacimiento, lo usaron de manera diametralmente opuesta al ideal armonioso al que representaba en un principio. Por lo tanto, hay fundamentos sólidos para considerar el manierismo como una etapa estilística válida e independiente, tal y como reivindicaban los historiadores de arte a principios del siglo XX. El término también se aplica a un estilo de pintura y dibujo que practicaban los artistas de Amberes durante un periodo ligeramente anterior, aproximadamente desde 1500 hasta 1530.";
                break;
            case 26:
                textoTitulo.text = "Rococó";
                textoCuerpo.text = "Es un estilo decorativo, que abarcó desde principios hasta mediados del siglo XVIII. Estaba presente principalmente en las artes decorativas en Europa, sobre todo, en Francia, en el sur de Alemania y en Austria. Sus características formales se basan en las formas asimétricas y de la naturaleza, que muestran una fascinación en particular por los objetos con forma de concha y los elementos marinos. Los artículos de estudio de este diccionario proporcionan más información sobre el rococó en los países pertinentes.";
                break;
            case 27:
                textoTitulo.text = "Neoclásico";
                textoCuerpo.text = "Término acuñado en la década de 1880 para hacer referencia a la última etapa de la tradición clásica en la arquitectura, la escultura, la pintura y las artes decorativas. El Neoclasicismo fue el movimiento sucesor del Rococó en la segunda mitad del siglo XVIII y estuvo relevado por varios estilos historicistas en la primera mitad del siglo XIX. Formó una parte fundamental de la Ilustración en su cuestionamiento radical de las nociones recibidas de los esfuerzos humanos. Este movimiento también se involucró profundamente en la necesidad de tomar nuevas posturas históricas frente al pasado, tanto clásicas como no clásicas, estimuladas por una gama de descubrimientos arqueológicos sin precedentes que se extendieron desde el sur de Italia y la zona este del Mediterráneo hasta Egipto y Oriente Medio durante la segunda mitad del siglo XVIII. La nueva conciencia de la pluralidad de los estilos históricos motivó la búsqueda de formas de expresión nuevas y contemporáneas. Este concepto de modernidad diferenció al neoclasicismo de las anteriores recuperaciones de estilos antiguos, estilos con los que, no obstante, guardaba una estrecha relación. Casi paradójicamente, la búsqueda de una forma de expresión atemporal (el “estilo verdadero”, como se le denominó entonces) abarcaba distintos enfoques respecto al diseño que se centraban notablemente en los aspectos del estilo greco-romano.";
                break;
            case 28:
                textoTitulo.text = "Realismo";
                textoCuerpo.text = "El realismo es un movimiento artístico desde mediados hasta finales del siglo XIX, por el que se pretendía crear representaciones objetivas del mundo externo basadas en la observación imparcial de la vida contemporánea. El realismo fue deliberadamente democrático, tanto en su temática como en sus actividades públicas y clases sociales, que antes no se consideraban dignas de representar en el arte. El desarrollo más congruente del realismo ocurrió en la pintura francesa, que se centró en la obra de Gustave Courbet. Este pintor usó el término “realismo” como título de un manifiesto presentado en una exposición de sus obras en 1855. Aunque su influencia se extendió durante el siglo XX, sus manifestaciones posteriores se denominan normalmente como realismo social.";
                break;
            case 29:
                textoTitulo.text = "Impresionismo";
                textoCuerpo.text = "El impresionismo es el término general para describir el movimiento artístico que nació en Francia a finales del siglo XIX. Este movimiento se extendió a otros países y dio lugar a corrientes como el impresionismo americano. El término “impresionista” se usa principalmente para referirse a un grupo de pintores franceses que trabajaron entre 1860 y 1900, y, especialmente, para describir sus obras de finales de los sesenta y mediados de los ochenta. Entre estos artistas, se encuentran Frédéric Bazille, Paul Cézanne, Edgar Degas, Edouard Manet, Claude Monet, Berthe Morisot, Camille Pissarro, Auguste Renoir y Alfred Sisley, así como Mary Cassatt, Gustave Caillebotte, que fue también de los primeros coleccionistas de renombre, Eva Gonzalès, Armand Guillaumin y Stanislas Lépine. El movimiento fue antiacadémico en cuanto a sus aspectos formales y, además del Salón de París, de carácter oficial, se establecieron otros espacios para exhibir y vender pinturas.";
                break;
            case 30:
                textoTitulo.text = "Fauvismo";
                textoCuerpo.text = "El fauvismo es un movimiento pictórico francés, que se desarrolló entre 1898 y 1906, y se caracterizó por un empleo excesivo del color, que a menudo se aplicaba sin mezclar y directamente de los tubos de pintura producidos comercialmente en superficies amplias y planas. Otras características son la espontaneidad e, incluso, la tosquedad de los trazos, así como una sensación llamativa del diseño de la superficie. Fue el primero de una sucesión de movimientos vanguardistas del arte del siglo XX y ejerció una gran influencia en las tendencias casi contemporáneas y posteriores, como el expresionismo, el orfismo y el desarrollo del arte abstracto.";
                break;
            case 31:
                textoTitulo.text = "Dadaísmo Surrealista";
                textoCuerpo.text = "El surrealismo es un movimiento intelectual internacional, que tuvo lugar principalmente en París y trató sobre los problemas de pensamiento y expresión en todas sus formas. Los surrealistas se percataron de que había una profunda crisis en la cultura occidental, y respondieron con una revisión de los valores a todos los niveles, que se basa en los descubrimientos psicoanalíticos de Freud y en la ideología política del marxismo. Tanto en poesía como en las artes plásticas, esta revisión se llevó a cabo a través del desarrollo de técnicas no convencionales, y para ello, el automatismo fue primordial. Los poetas parisinos que elaboraron la teoría y el enfoque surrealistas fueron reconocidos oficialmente en el “Manifiesto surrealista” de André Breton (1924), en el ensayo “Una ola de sueños” (octubre de 1924) de Louis Aragon y en el periódico “La revolución surrealista”, publicado dos meses más tarde. Bajo la dirección de Breton, el movimiento se mantuvo firme hasta la Segunda Guerra Mundial y aguantó hasta su muerte en 1966.";
                break;
            case 32:
                textoTitulo.text = "Minimalismo";
                textoCuerpo.text = "Término utilizado en el siglo XX, concretamente a partir de la década de los sesenta, para describir un estilo caracterizado por la austeridad que prescinde de lo personal, una configuración sencilla geométrica y el uso de materiales procesados de manera industrial. El término “minimalismo” lo usó por primera vez David Burlyuk en la introducción al catálogo de una exposición de las pinturas de John Graham en la Galería Dudensing de Nueva York, en 1929. Burlyuk escribió: “El minimalismo recibe este nombre porque recurre a los medios operativos mínimos. La pintura minimalista es puramente realista, es decir, el sujeto se representa a sí mismo”. El uso de este término se extendió en la década de los sesenta, aunque las explicaciones y las aclaraciones sobre su significado y sobre la gama de obras con la que guardaba relación variaban considerablemente. Algunas de estas obras eran, por ejemplo, las pinturas monocromáticas de Yves Klein, las obras de Robert Rauschenberg, Ad Reinhardt, Frank Stell y Brice Marden, así como algunos aspectos del pop art y la abstracción pospictórica. Habitualmente, los precedentes que se mencionan son los “ready-mades” de Duchamp. Las composiciones supremacistas de Kazimir Malevich y las pinturas de expresionismo abstracto de Narnett Newman. Las pinturas a partir de composiciones de cuadrículas de Agnes Martin también se mencionan en relación con determinados artistas minimalistas como Sol LeWitt.";
                break;
            case 33:
                textoTitulo.text = "Art Nouveau";
                textoCuerpo.text = "Estilo decorativo de finales del siglo XIX y principios del XX que prosperó principalmente en Europa y EE. UU. Aunque tuvo influencia en la pintura y en la escultura, sus principales manifestaciones se produjeron en la arquitectura y en las artes decorativas y gráficas, aspectos en los que se centra este estudio. Sus características son líneas sinuosas y asimétricas basadas en formas orgánicas. En un sentido más amplio, el “art nouveau” abarca los ritmos y formas más abstractas y geométricas que evolucionaron como parte de la reacción general al historicismo del siglo XIX. Hay una amplia variedad dentro del estilo en función del lugar de origen y de los materiales empleados.";
                break;
            case 34:
                textoTitulo.text = "Arte Decó";
                textoCuerpo.text = "Término descriptivo que se aplica a un estilo de arte decorativa que se extendió por toda Europa y Estados Unidos durante la década de los veinte y los treinta. Aunque procede del estilo que se popularizó a partir de la Exposición Internacional de Artes Decorativas e Industriales que tuvo lugar en París en 1925, no comenzó a usarse hasta finales de la década de los sesenta, cuando resurgió el interés en las artes decorativas de principios del siglo XX. Desde entonces, el término “art déco” se ha aplicado a una amplia variedad de obras creadas durante el periodo de entreguerras e incluso a algunas elaboradas por la Bauhaus alemana. Sin embargo, el “art déco” tiene un origen esencialmente francés, por lo que el término debe aplicarse exclusivamente a obras creadas por franceses o en países que recibieran una influencia directa de Francia.";
                break;
            case 35:
                textoTitulo.text = "Memphis";
                textoCuerpo.text = "Memphis es un movimiento de diseño que comenzó en 1981. Aunque el nombre podría hacer pensar que nació en Tennesse, tuvo sus inicios en Milán, Italia. El diseñador Ettore Sottsass fundó el Grupo Memphis con otros diseñadores y arquitectos. Tomaron su nombre de una canción de Bob Dylan titulada Stuck Inside of Mobile with the Memphis Blues Again que se repetía durante su primera reunión.";
                break;
            case 36:
                textoTitulo.text = "Arte Kitsch";
                textoCuerpo.text = "Es un estilo artístico considerado «cursi», «adocenado», «siútico», «hortera» o «trillado» y, en definitiva, vulgar aunque pretencioso y por tanto no sencillo ni clásico, sino de mal gusto y regresivo o infantiloide. Fue definido en el campo de la estética en los años treinta por Hermann Broch (1886-1951), Walter Benjamin (1892-1940), Theodor Adorno (1903-1969) y Clement Greenberg (1909-1994), con el propósito de definir lo opuesto al arte de Vanguardia o avant-garde. En aquella época el mundo del arte percibía la popularidad de lo kitsch como un peligro para la cultura. Más tarde fue definido sobre todo en Alemania en los años setenta. Desde un punto de vista marxista, Theodor Adorno percibía lo kitsch en términos de lo que él llamaba la industria cultural, donde el arte es controlado y planeado por las necesidades del mercado y es dado a un pueblo pasivo que lo acepta. Lo que es comercializado es un arte que no cambia y que es formalmente incoherente, pero que sirve para dar a la audiencia ocio y algo que mirar.";
                break;
            case 37:
                textoTitulo.text = "Op Art";
                textoCuerpo.text = "La primera vez que el término Op (de optical, óptico) se aplicó a lo artístico fue en 1964, en una crítica de la revista Time. Los quisquillosos pueden pensar que decir Op Art es un pleonasmo, porque todo arte plástico es visual, pero el nombre de esta corriente se debe a que sus artistas acentúan en sus trabajos, y sobre todo en la recepción que esperan de ellos, algunos fenómenos perceptivos visuales, ciertos efectos ópticos.";
                break;
            case 38:
                textoTitulo.text = "Hiperrealismo";
                textoCuerpo.text = "El hiperrealismo es un estilo de pintura, de técnicas de impresión y de escultura surgido en EE. UU. a mediados de los años sesenta, que propone la reproducción exacta de una fotografía en pintura o la imitación de objetos reales en escultura. Los precursores de esta tendencia fueron los pintores Malcolm Morley, Chuck Close, Richard Estes, Audrey Flack, Robert Bechtle (nacido en 1932), Robert Cottingham (nacido en 1935), Richard McLean (nacido en 1934), Don Eddy y el británico John Salt (nacido en 1937), así como los escultores Duane Hanson y John De Andrea. Aunque fue un movimiento básicamente norteamericano, también tuvo exponentes en Europa, por ejemplo, Franz Gertsch.";
                break;
        }
    }
}
