# ✨Control Hub Test ✨


> The purpose of the project is to obtain the N value of the Fibonacci
> series. The technology used is .Net 6 using a layered architecture,
> since it is a problem of mathematical computational consumption and is
> unique, it is advisable to use the least amount of inherited classes
> possible without losing good programming practices as suggested by the
> Clean Code principles. The api responds with states of 200 and 500
> which are http response standards. Also, to calculate the N value of
> the Fibonacci series, a "GetValue" recursion method is used that
> validates the first two values ​​0 and 1 and returns that value;
> otherwise add the two previous numbers.

**Layers:**

 1. Entity Layer (ControlHub.BE): The data types to be used for the FibonacciBE class have been established with the values ​​index and value.

 1. Business Layer (ControlHub.BL): Allows the execution of the calculation of the value of the N term in the FibonacciBL class in the GetValueFibonacci method.

 1. Presentation Layer (ControlHub.Api): Exposes the api with the result of the index that was sent. Additionally, a base class (BaseController) is added for the base route of the api.
Improve Initial Project:

For a project that requires greater use of business logic, it is advisable to use a clean architecture since it allows for a better division of the parts of a project, as well as allowing interaction with more work teams. This or another software architecture is recommended to implement because it allows the application to be more scalable, efficient and uses good development practices in large projects.
Likewise, the security of the data that travels to the api can be improved using security practices of the OWASP standard to reduce security flaws in the entry and exit of data from the application.

**Routes:**

 1. The application path is localhost:44369/api/Fibonacci/{index} where {index} is the index of the position that is sent to get the value

 1. Swagger: https://localhost:44369/swagger/index.html



# ✨Control Hub Test ✨

> El proyecto tiene como finalidad obtener el valor N de la serie
> Fibonacci. La tecnología usada es .Net 6 usando una arquitectura en
> capas, debido a que es un problema de consumo computacional matemático
> y único es recomendable usar la menor cantidad de clases heredadas
> posibles sin perder las buenas prácticas de programación como sugiere
> los principios de Código Limpio.

El api responde con estados de 200 y 500 que son estándares de respuesta http asimismo para calcular el valor N de la serie Fibonacci se usa un método de recursividad “GetValue” que validad los dos primeros valores 0 y 1 y retorna ese valor; en caso contrario suma los dos números anteriores.
Capas:

 1. Capa Entidad *(ControlHub.BE)*: Se estable los tipos de datos a usar
    para la clase FibonacciBE con los valores index y value.
 2. Capa Negocio *(ControlHub.BL)*: Permite realizar la ejecución del cálculo del valor del N termino en la clase FibonacciBL en el método GetValueFibonacci.
 3. Capa Presentación *(ControlHub.Api)*: Expone el api con el resultado del index que se envió. Adicional se agrega una clase base(BaseController) para la ruta base de la api.
 
**Mejorar al Proyecto Inicial:**

Un proyecto que requiere mayor uso de lógica de negocio es recomendable usar una arquitectura limpia ya que permite dividir mejor las partes de un proyecto asimismo permite interactuar con mas equipos de trabajo. Esta u otra arquitectura de software es recomendable a implementar debido a que permite que la aplicación sea mas escalable, eficiente y utiliza buenas practicas de desarrollo en proyectos de gran tamaño.
Así mismo la seguridad de los datos que viajan al api se puede mejorar usando prácticas de seguridad del estándar OWASP para disminuir fallas de seguridad en la entrada y salida de datos de la aplicación.

**Rutas:**

 1. La ruta de la aplicación es localhost:44369/api/Fibonacci/{index} donde {index} es el índice de la posición que se envía para obtener el valor

 1. Swagger: https://localhost:44369/swagger/index.html
