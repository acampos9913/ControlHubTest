El proyecto tiene como finalidad obtener el valor N de la serie Fibonacci.
La tecnología usada es .Net 6 usando una arquitectura en capas, debido a que es un problema de consumo computacional matemático y único es recomendable usar la menor cantidad de clases heredadas posibles sin perder las buenas prácticas de programación como sugiere los principios de Código Limpio.
El api responde con estados de 200 y 500 que son estándares de respuesta http asimismo para calcular el valor N de la serie Fibonacci se usa un método de recursividad “GetValue” que validad los dos primeros valores 0 y 1 y retorna ese valor; en caso contrario suma los dos números anteriores.
Capas:
-	Capa Entidad (ControlHub.BE): Se estable los tipos de datos a usar para la clase FibonacciBE con los valores index y value.
-	Capa Negocio (ControlHub.BL): Permite realizar la ejecución del cálculo del valor del N termino en la clase FibonacciBL en el método GetValueFibonacci.
-	Capa Presentación (ControlHub.Api): Expone el api con el resultado del index que se envió. Adicional se agrega una clase base(BaseController) para la ruta base de la api.
Mejorar al Proyecto Inicial:
Un proyecto que requiere mayor uso de lógica de negocio es recomendable usar una arquitectura limpia ya que permite dividir mejor las partes de un proyecto asimismo permite interactuar con mas equipos de trabajo. Esta u otra arquitectura de software es recomendable a implementar debido a que permite que la aplicación sea mas escalable, eficiente y utiliza buenas practicas de desarrollo en proyectos de gran tamaño.
Así mismo la seguridad de los datos que viajan al api se puede mejorar usando prácticas de seguridad del estándar OWASP para disminuir fallas de seguridad en la entrada y salida de datos de la aplicación.

Rutas:
La ruta de la aplicación es localhost:44369/api/Fibonacci/{index} donde {index} es el índice de la posición que se envía para obtener el valor
Swagger: https://localhost:44369/swagger/index.html
