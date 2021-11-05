using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class gamecontroller : MonoBehaviour
{   
     public GameObject text1;
     public GameObject text2;
     public GameObject sign;
     public GameObject wrong;
     public GameObject right;

     string num3 ;
     int num1 ;
     int num2 ;

     string input ;
     private void Start() {
        
         num1 = Random.Range(1,100);
         num2 = Random.Range(1,100);
         
        if (btnclick.add_ == true)
        {
             doadd();
            
        }
        else if (btnclick.sub_ == true)
        {
            dosub();
        }
        else if (btnclick.mul_ == true)
        {
            domul();
        }
        else if (btnclick.div_ == true)
        {
            dodiv();
        }
        
        else if (btnclick.mix_ == true)
        {
            domix();
        }

     }


      public void ReadStringInput(string i){

          input = i ;
          print(input);


      }

      public void gotonext(){
   if (btnclick.add_ == true)
        {
             doadd();
            
        }
        else if (btnclick.sub_ == true)
        {
            dosub();
        }
        else if (btnclick.mul_ == true)
        {
            domul();
        }
        else if (btnclick.div_ == true)
        {
            dodiv();
        }
        
        else if (btnclick.mix_ == true)
        {
            domix();
        }


      }
       public void gobackhome (){


       SceneManager.LoadScene("gamemenu");
            
            
            btnclick.add_ = false ;
            btnclick.div_ = false ;
            btnclick.mul_ = false ;
            btnclick.sub_ = false ;


   }
     public void doadd()
        {
          
           num1 = Random.Range(1,100);
           num2 = Random.Range(1,100);
           
           
            Text text1_ = text1.GetComponent<Text>();
            text1_.text = num1.ToString();
            
            Text text2_ = text2.GetComponent<Text>();
            text2_.text = num2.ToString();
            Text sign_ = sign.GetComponent<Text>();
            sign_.text = "+";

            num3 = (num1 + num2).ToString() ;
          
         
        }
          public void checkans(){
                if (num3==input)
                {
                    right.SetActive(true);
                }
                else
                {
                    wrong.SetActive(true);
                    
                }
            }
            public void cancelpopup(){
                 wrong.SetActive(false); 
                 right.SetActive(false);
            }
      public void dosub()
        {
               num1 = Random.Range(1,100);
              num2 = Random.Range(1,100);
           Text sign_ = sign.GetComponent<Text>();
            sign_.text = "-";
           
            Text text1_ = text1.GetComponent<Text>();
            text1_.text = num1.ToString();
            
            Text text2_ = text2.GetComponent<Text>();
            text2_.text = num2.ToString();

            num3 = (num1 - num2).ToString() ;


        }
       public void domul()
        {
               num1 = Random.Range(1,100);
           num2 = Random.Range(1,100);
           Text sign_ = sign.GetComponent<Text>();
            sign_.text = "×";
           
            Text text1_ = text1.GetComponent<Text>();
            text1_.text = num1.ToString();
            
            Text text2_ = text2.GetComponent<Text>();
            text2_.text = num2.ToString();

            num3 = (num1 * num2).ToString() ;

        }
      public void dodiv()
        {

               num1 = Random.Range(1,100);
           num2 = Random.Range(1,100);
             Text sign_ = sign.GetComponent<Text>();
            sign_.text = "÷";
           
            Text text1_ = text1.GetComponent<Text>();
            text1_.text = num1.ToString();
            
            Text text2_ = text2.GetComponent<Text>();
            text2_.text = num2.ToString();

            num3 = (num1 / num2).ToString() ;

        }
  public void domix(){

num1 = Random.Range(1,5);
if (num1==1)
{
    doadd();
}
if (num1==2)
{
    dosub();
}
if (num1==3)
{
    domul();
}
if (num1==4)
{
    dodiv();
}




  }
     


      






}
