using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class gamecontroller : MonoBehaviour
{   
     public GameObject text1;
     public GameObject text2;
     public GameObject sign;
     public GameObject wrong;
     public GameObject right;
     public GameObject Division;

     public GameObject win;
     public GameObject lose;

  
     public TMP_InputField input1;
     public TMP_Text score;

     public static int scorenum = 0;
     string num3 ;
     int num1 ;
     int num2 ;
     int RandomNum;

     string input ;
     private void Start() {
        
         
         score.text = (PlayerPrefs.GetInt("highscore",0)).ToString();
         scorenum = PlayerPrefs.GetInt("highscore",0);
         Diffculty();
         
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
            Division.SetActive(true);
            dodiv();
        }
        
        else if (btnclick.mix_ == true)
        {
            domix();
        }

     }

      private void Diffculty(){
            if (scorenum >= 30){
                num1 = Random.Range(1,100);
                num2 = Random.Range(1,100); 
            }else if (scorenum >= 20 && scorenum < 30){
                num1 = Random.Range(1,50);
                num2 = Random.Range(1,50);}
            else if (scorenum >= 10 && scorenum < 20){
                num1 = Random.Range(1,20);
                num2 = Random.Range(1,20);}
            else if (scorenum >= 0 && scorenum < 10){
                num1 = Random.Range(1,10);
                num2 = Random.Range(1,10);}
            
      }
      public void ReadStringInput(string i){

          input = i ;
          }

     public void gotonext(){
      
       if (btnclick.add_ == true && Adsmanger.succad == true )
        {
             doadd();
            
        }
        else if (btnclick.sub_ == true && Adsmanger.succad == true)
        {
            dosub();
        }
        else if (btnclick.mul_ == true && Adsmanger.succad == true)
        {
            domul();
        }
        else if (btnclick.div_ == true && Adsmanger.succad == true)
        {
            dodiv();
        }
        
        else if (btnclick.mix_ == true && Adsmanger.succad == true)
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
            btnclick.mix_ = false ;


   }
     public void doadd()
        {
          
           Diffculty();
           
           
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
                    win.GetComponent<AudioSource>().Play();
                    Adsmanger.succad = true;
                    scorenum += 1;
                    PlayerPrefs.SetInt("highscore",scorenum);
                    score.text = scorenum.ToString();

                }
                else
                {
                    wrong.SetActive(true);
                     lose.GetComponent<AudioSource>().Play();
                }

                input1.text="";
            }
            public void cancelpopup(){
                 wrong.SetActive(false); 
                 right.SetActive(false);
                 Division.SetActive(false);
            }
      public void dosub()
        {
            Diffculty();
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
           Diffculty();
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

           Diffculty();
             Text sign_ = sign.GetComponent<Text>();
            sign_.text = "÷";
           
            Text text1_ = text1.GetComponent<Text>();
            text1_.text = num1.ToString();
            
            Text text2_ = text2.GetComponent<Text>();
            text2_.text = num2.ToString();

            num3 = (num1 / num2).ToString() ;

        }
  public void domix(){

RandomNum = Random.Range(1,5);
if (RandomNum==1)
{
    doadd();
}
if (RandomNum==2)
{
    dosub();
}
if (RandomNum==3)
{
    domul();
}
if (RandomNum==4)
{
    dodiv();
}




  }
     


      






}
