CREATE TABLE `ordendetrabajo` (
  `id` int(11) NOT NULL,
  `tipo` varchar(45) DEFAULT NULL,
  `fechaSolicitud` datetime DEFAULT NULL,
  `descripcion` varchar(200) DEFAULT NULL,
  `idClienteContratante` int(11) DEFAULT NULL,
  `idProfesionalSeleccionado` int(11) DEFAULT NULL,
  `numeroHorasLaboradas` decimal(20,2) DEFAULT NULL,
  `valorPorHoraPactado` decimal(20,2) DEFAULT NULL,
  `iniciado` tinyint(4) DEFAULT NULL,
  `finalizado` tinyint(4) DEFAULT NULL,
  `cancelado` tinyint(4) DEFAULT NULL,
  `calificacionDadaACliente` decimal(20,2) DEFAULT NULL,
  `calificacionDadaAProfesional` decimal(20,2) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


CREATE TABLE `profesional` (
  `id` int(11) NOT NULL,
  `nombre` varchar(150) DEFAULT NULL,
  `profesion` varchar(100) DEFAULT NULL,
  `rankingcalificacion` decimal(20,2) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

