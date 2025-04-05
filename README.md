# Árbol Binario de Búsqueda en C#

Este proyecto implementa un Árbol Binario de Búsqueda (BST) en C# y proporciona pruebas unitarias para verificar su correcto funcionamiento. Los BST son estructuras de datos que permiten realizar operaciones de búsqueda, inserción y eliminación de manera eficiente.

## Contenido

- [Descripción](#descripción)
- [Estructura del Proyecto](#estructura-del-proyecto)
- [Implementación del BST](#implementación-del-bst)
- [Pruebas Unitarias](#pruebas-unitarias)
- [Instrucciones de Uso](#instrucciones-de-uso)
- [Autores](#autores)

## Descripción

Un Árbol Binario de Búsqueda (BST) es un árbol binario que cumple con la siguiente propiedad: para cada nodo, todos los nodos del subárbol izquierdo tienen un valor menor que el nodo y todos los nodos del subárbol derecho tienen un valor mayor que el nodo. Este proyecto implementa un BST utilizando nodos enlazados e incluye operaciones de búsqueda, inserción, eliminación y recorridos.

## Estructura del Proyecto

El proyecto contiene los siguientes archivos:

- `TreeNode.cs`: Define la clase `TreeNode` que representa un nodo en el BST.
- `BinarySearchTree.cs`: Implementa el BST con sus métodos de búsqueda, inserción, eliminación y recorridos.
- `BinarySearchTreeTests.cs`: Contiene pruebas unitarias para verificar el correcto funcionamiento del BST.

## Implementación del BST

La implementación del BST incluye las siguientes operaciones:

- **Búsqueda**: Busca un nodo en el BST.
- **Inserción**: Inserta un nodo en el BST.
- **Eliminación**: Elimina un nodo del BST.
- **Recorridos**: Realiza recorridos inorden, preorden y postorden del BST.

### Ejemplo de Uso

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        BinarySearchTree bst = new BinarySearchTree();

        // Inserción de nodos
        bst.Insert(10);
        bst.Insert(5);
        bst.Insert(15);

        // Búsqueda de nodos
        bool found = bst.Search(10); // true

        // Eliminación de nodos
        bst.Delete(5);

        // Recorridos
        bst.InOrder();   // Imprime: 10 15
        bst.PreOrder();  // Imprime: 10 15
        bst.PostOrder(); // Imprime: 15 10
    }
}
```

## Pruebas Unitarias

Las pruebas unitarias se han implementado utilizando el framework xUnit. Las pruebas verifican las operaciones de inserción, búsqueda, eliminación y recorridos del BST.

### Ejecución de Pruebas

Para ejecutar las pruebas unitarias, utiliza el siguiente comando en la línea de comandos:

```bash
dotnet test
```

## Instrucciones de Uso

1. Clona el repositorio.
2. Abre el proyecto en Visual Studio o tu IDE favorito.
3. Compila y ejecuta el proyecto.
4. Ejecuta las pruebas unitarias para verificar el correcto funcionamiento del BST.

## Autores

- **(Adrián Monge Mairena)[https://github.com/Preko700]** - Implementación y pruebas unitarias
