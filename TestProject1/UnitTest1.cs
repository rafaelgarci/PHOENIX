using CapaNegocio;
using CapaEntidad;
using CapaDatos;
namespace TestProject1
{ 
    [TestClass]
    public class TestUnitarioUsuario
    {
        // prueba para simular registro de usuario 
        [TestMethod]
        public void TestMethod1()
        {
            bool result = CapaNegocio.CN_Usuarios.RegistrarUsuario("rafael", "garcia", "bgarcia@gmail.com", "12345");
            Assert.IsTrue(result);
            
        }

        // prueba con un campo incorrecto 

        [TestMethod]
        public void TestMethod2()
        {
            bool result = CapaNegocio.CN_Usuarios.RegistrarUsuario("rafael", " ", "bgarcia@gmail.com", "12345");
            Assert.IsFalse(result);
           
        }
    }

    [TestClass]
    public class TestDescripcionProducto // test para descripcion de un producto 
    {
        [TestMethod]
        public void TestDescripcion()
        {
            bool result = CapaNegocio.CN_Usuarios.Descripcionproducto("pijama en seda talla S");
            Assert.IsTrue(result);
        }

        [TestMethod]
           // en caso de estar vacia la descripcion de producto 
        public void TestDescripcion2()
        {
            bool result= CapaNegocio.CN_Usuarios.Descripcionproducto("   ");
            Assert.IsFalse(result);
        }
    
    
    }
}  