﻿/*
 * Created by SharpDevelop.
 * User: den
 * Date: 28/11/2023
 * Time: 22:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
namespace Trabajo_Final_2023
{
    public class Club
    {
        //variables de instancias y de clase
        
        private string nombre;
        private ArrayList listaCatyDepo;
        //  private ArrayList listaNiños;
        private ArrayList listaEntrenadores;
        private ArrayList listaSocios;
        
        //constructores
        public Club(string nom){

            nombre  = nom;
            listaCatyDepo= new ArrayList();
            //listaNiños = new ArrayList();
            listaEntrenadores = new ArrayList();
            listaSocios = new ArrayList();
        }
        public Club(){}
        
        //propiedades get set
        public string Nombre{
            set{nombre=value;}
            get{return nombre;}
        }
        
        //metodos con lista de categoria y deporte
        public void agregarDeportexCat(Cat_y_Depo d){
            listaCatyDepo.Add(d);
            
        }
        
        public void eliminar_Deporte(Cat_y_Depo esteDep){
        	if (esteDep.Cupo == 15){
                listaCatyDepo.Remove(esteDep);
                Console.WriteLine("Baja exitosa");
        	}
            
            
            else
                Console.WriteLine("Este deporte posee inscriptos, no debe ser eliminado");
        }
        
        public ArrayList retornaListaCat_yDep(){
            return listaCatyDepo;
        }
        
        public Cat_y_Depo buscarDeporte( int buscoCodigo){
            foreach (Cat_y_Depo d in listaCatyDepo) {
                if (d.Codigo == buscoCodigo)
                    return d;  }
                
            return null;
            }
            
        
  
        
        
        //metodo para verificar entrenador, lanza la excepcion ya existe entrenador
        public bool verificarEntrenador( string nom, int nuevoDni ){
            foreach(Entrenador e in listaEntrenadores ){
                if(e.Dni == nuevoDni) {
                    
                    return true;
                    
                }
        		
            }
        	return false;
            
       }
        public void alta_Entrenador(Entrenador e){
        	listaEntrenadores.Add(e);
        }
        
        
        
        public void baja_Entrenador(Entrenador bajaE){
            listaEntrenadores.Remove(bajaE);
            
        }
        
        public ArrayList retornaListaEntrenadores(){
            return listaEntrenadores;
        }
        
  
        
        //metodo para imprimir niños inscriptos x deporte
        
        public void mostrarInscriptosxDeporte (string deporte){
            foreach (Cat_y_Depo dep in listaCatyDepo) {
                if (dep.NombreDep == deporte)
                    dep.imprimirListaNiños();}
        }
        
        
        //metodo para imprimir niños inscriptos x deporte y categoria
        
        public void mostrarInscriptosxDeporteyCat (string deporte, string cat){
            foreach (Cat_y_Depo dep in listaCatyDepo) {
                if ((dep.NombreDep == deporte) && (dep.Categoria== cat))
                    dep.imprimirListaNiños();}
            
        }
    }
}
