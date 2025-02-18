﻿public class Encuesta
{
    public List<SeccionEncuesta> Secciones { get; set; }

    public Encuesta()
    {
        Secciones = new List<SeccionEncuesta>
        {
            new SeccionEncuesta
            {
                Nombre = "Demografía",
                Preguntas = new List<Pregunta>
                {
                    new Pregunta
                    {
                        Texto = "¿Cuál es su país de residencia?",
                        TipoRespuesta = TipoRespuesta.Unica,
                        Estado = false,
                        Ponderacion = 5
                    },
                    new Pregunta
                    {
                        Texto = "¿En qué rango de edad se encuentra?",
                        TipoRespuesta = TipoRespuesta.Unica,
                        Estado = false,
                        Ponderacion = 5
                    }
                }
            },
            new SeccionEncuesta
            {
                Nombre = "Opinión sobre el producto",
                Preguntas = new List<Pregunta>
                {
                    new Pregunta
                    {
                        Texto = "Califique la calidad del producto",
                        TipoRespuesta = TipoRespuesta.Multiple,
                        Estado = false,
                        Ponderacion = 7
                    },
                    new Pregunta
                    {
                        Texto = "Califique el servicio al cliente",
                        TipoRespuesta = TipoRespuesta.Multiple,
                        Estado = false,
                        Ponderacion = 8
                    }
                }
            },
            new SeccionEncuesta
            {
                Nombre = "Comentarios finales",
                Preguntas = new List<Pregunta>
                {
                    new Pregunta
                    {
                        Texto = "¿Agregaría algún comentario adicional?",
                        TipoRespuesta = TipoRespuesta.Unica,
                        Estado = false,
                        Ponderacion = 10
                    }
                }
            }
        };
    }
}

