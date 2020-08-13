using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.VFX;

public class FlyCatch : MonoBehaviour
{
    // Start is called before the first frame update

    
    public float speedX;
    public float speedY;
    public float speedZ;
    public int number;
    public bool isStart=false;
    public bool isEmpty = true;
    public bool isFly = false;
    private float m_x;
    private UnityEngine.Vector3 m_Offset;
    public float t;
    public int mark;

    public UnityEngine.Vector3 target1;
    public UnityEngine.Vector3 target2;

    void Start()
    {
        
        

    }

    // Update is called once per 
    void Update()
    {
        if(isStart)
        {
            if (!isFly)
            {
                speedX = 0.3f;
                m_Offset.x = 9.5f;
                m_Offset.y = 1.38f;
                m_Offset.z = 7f;
                this.transform.position = UnityEngine.Vector3.MoveTowards(transform.position, target1, speedX * Time.deltaTime);
            }

            if (this.transform.position == target1)
            {
                isFly = true;
                
            }
            if(isFly)
            {
                t = t + Time.deltaTime;
                speedY = 0.3f;
            }
        }

        if (isFly & isStart)
        ///货架一
        {
            if (t < (2.4 / speedY))
            {
                this.transform.Translate(0, 0, speedY * Time.deltaTime);

            }
            if (t >= 2.4 / speedY & t < 2.4 / speedY + 0.5)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }


            if (t >= 2.4 / speedY + 0.5 & t < 3 / speedY + 0.5)
            {
                this.transform.Translate(0, -speedY * Time.deltaTime, 0);
            }
            if (t >= 3 / speedY + 0.5 & t < 3 / speedY + 1)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }


            if (t >= 3 / speedY + 1 & t < 3.6 / speedY + 1)
            {
                this.transform.Translate(0, 0, speedY * Time.deltaTime);
            }
            if (t >= 3.6 / speedY + 1 & t < 3.6 / speedY + 1.5)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }


            if (t >= 3.6 / speedY + 1.5 & t < 4.2 / speedY + 1.5)
            {
                this.transform.Translate(0, speedY * Time.deltaTime, 0);
            }
            if (t >= 4.2 / speedY + 1.5 & t < 4.2 / speedY + 2)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }


            ///货架二
            if (t > 4.2 / speedY + 2 & t <= 5.55 / speedY + 2)
            {
                this.transform.Translate(0, 0, speedY * Time.deltaTime);
            }
            if (t >= 5.55 / speedY + 2 & t < 5.55 / speedY + 2.5)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }


            if (t > 5.55 / speedY + 2.5 & t < 6.15 / speedY + 2.5)
            {
                this.transform.Translate(0, -speedY * Time.deltaTime, 0);
            }
            if (t >= 6.15 / speedY + 2.5 & t < 6.15 / speedY + 3)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }


            if (t >= 6.15 / speedY + 3 & t < 6.75 / speedY + 3)
            {
                this.transform.Translate(0, 0, speedY * Time.deltaTime);
            }
            if (t >= 6.75 / speedY + 3 & t < 6.75 / speedY + 3.5)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }


            if (t >= 6.75 / speedY + 3.5 & t <= 7.35 / speedY + 3.5)
            {
                this.transform.Translate(0, speedY * Time.deltaTime, 0);
            }
            if (t >= 7.35 / speedY + 3.5 & t < 7.35 / speedY + 4)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }


            ///货架三
            if (t > 7.35 / speedY + 4 & t <= 8.7 / speedY + 4)
            {
                this.transform.Translate(0, 0, speedY * Time.deltaTime);
            }
            if (t >= 8.7 / speedY + 4 & t < 8.7 / speedY + 4.5)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }


            if (t > 8.7 / speedY + 4.5 & t < 9.3 / speedY + 4.5)
            {
                this.transform.Translate(0, -speedY * Time.deltaTime, 0);
            }
            if (t >= 9.3 / speedY + 4.5 & t < 9.3 / speedY + 5)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }


            if (t >= 9.3 / speedY+5 & t < 9.9 / speedY+5)
            {
                this.transform.Translate(0, 0, speedY * Time.deltaTime);
            }
            if (t >= 9.9/ speedY+5 & t < 9.9/ speedY + 5.5)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }

            if (t >= 9.9 / speedY+5.5 & t <= 10.5 / speedY+5.5)
            {
                this.transform.Translate(0, speedY * Time.deltaTime, 0);
            }
            if (t >= 10.5 / speedY+5.5 & t < 10.5 / speedY + 6)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }

            ///货架四
            if (t > 10.5 / speedY+6 & t <= 11.85 / speedY+6)
            {
                this.transform.Translate(0, 0, speedY * Time.deltaTime);
            }
            if (t >= 11.85 / speedY+6 & t < 11.85 / speedY + 6.5)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }


            if (t > 11.85 / speedY+6.5 & t < 12.45 / speedY+6.5)
            {
                this.transform.Translate(0, -speedY * Time.deltaTime, 0);
            }
            if (t >= 12.45 / speedY+6.5 & t < 12.45/ speedY + 7)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }


            if (t >= 12.45 / speedY+7 & t < 13.05 / speedY+7)
            {
                this.transform.Translate(0, 0, speedY * Time.deltaTime);
            }
            if (t >= 12.45 / speedY+7 & t < 12.45 / speedY + 7.5)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }


            if (t >= 13.05 / speedY+7.5 & t <= 13.65 / speedY+7.5)
            {
                this.transform.Translate(0, speedY * Time.deltaTime, 0);
            }
            if (t >= 13.65 / speedY+7.5 & t < 13.65 / speedY + 8)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }


            ///正面结束
            if (t > 13.65 / speedY+8 & t <= 16.05 / speedY+8)
            {
                this.transform.Translate(0, 0, speedY * Time.deltaTime);
                m_x = transform.position.x;
            }

            ///转向并调头
            if (t > 16.05 / speedY+8 & t < 17.15 / speedY+8)
            {
                m_Offset.x = speedY * Time.deltaTime;
                m_Offset.y = 0;
                m_Offset.z = 0;
                if (this.transform.position.x < (m_x + 1.5))
                { this.transform.position = this.transform.position + m_Offset; };
                this.transform.Rotate(0, (float)(180 / (1.1 / speedY)) * Time.deltaTime, 0);
            }


            if (t >= 17.15 / speedY+8 & t < 18.7 / speedY+8)
            {
                mark = 1;
                this.transform.Translate(0, 0, speedY * Time.deltaTime);
            }
            if (t >= 18.7/ speedY+8 & t < 18.7 / speedY + 8.5)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }


            if (t >= 18.7 / speedY+8.5 & t < 19.3 / speedY+8.5)
            {
                this.transform.Translate(0, -speedY * Time.deltaTime, 0);
            }
            if (t >= 19.3 / speedY+8.5 & t < 19.3/ speedY + 9)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }


            if (t >= 19.3 / speedY+9 & t < 19.9 / speedY+9)
            {
                this.transform.Translate(0, 0, speedY * Time.deltaTime);
            }
            if (t >= 19.9 / speedY+9 & t < 19.9 / speedY + 9.5)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }


            if (t >= 19.9 / speedY+9.5 & t < 20.5 / speedY+9.5)
            {
                this.transform.Translate(0, speedY * Time.deltaTime, 0);
            }
            if (t >= 20.5/ speedY+9.5 & t < 20.5/ speedY + 10)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }


            ///货架二
            if (t > 20.5 / speedY+10 & t <= 21.85 / speedY+10)
            {
                this.transform.Translate(0, 0, speedY * Time.deltaTime);
            }
            if (t >= 21.85/ speedY+10 & t < 21.85/ speedY + 10.5)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }


            if (t > 21.85 / speedY+10.5 & t < 22.45 / speedY+10.5)
            {
                this.transform.Translate(0, -speedY * Time.deltaTime, 0);
            }
            if (t >= 22.45 / speedY+10.5 & t < 22.45/ speedY + 11)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }


            if (t >= 22.45 / speedY+11 & t < 23.05 / speedY+11)
            {
                this.transform.Translate(0, 0, speedY * Time.deltaTime);
            }
            if (t >= 23.05/ speedY + 11 & t < 23.05 / speedY + 11.5)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }


            if (t >= 23.05 / speedY+11.5 & t <= 23.65 / speedY+11.5)
            {
                this.transform.Translate(0, speedY * Time.deltaTime, 0);
            }
            if (t >= 23.65 / speedY + 11.5 & t < 23.65/ speedY + 12)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }


            ///货架三
            if (t > 23.65 / speedY+12 & t <= 25 / speedY+12)
            {
                this.transform.Translate(0, 0, speedY * Time.deltaTime);
            }
            if (t >= 25 / speedY + 12 & t < 25 / speedY + 12.5)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }



            if (t > 25 / speedY+12.5 & t < 25.6 / speedY+12.5)
            {
                this.transform.Translate(0, -speedY * Time.deltaTime, 0);
            }
            if (t >= 25.6/ speedY + 12.5 & t < 25.6/ speedY +13)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }


            if (t >= 25.6 / speedY+13 & t < 26.2 / speedY+13)
            {
                this.transform.Translate(0, 0, speedY * Time.deltaTime);
            }
            if (t >= 26.2 / speedY + 13 & t < 26.2 / speedY + 13.5)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }


            if (t >= 26.2 / speedY+13.5 & t <= 26.8 / speedY+13.5)
            {
                this.transform.Translate(0, speedY * Time.deltaTime, 0);
            }
            if (t >= 26.8 / speedY + 13.5 & t < 26.8 / speedY + 14)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }

            ///货架四
            if (t > 26.8 / speedY+14 & t <= 28.15 / speedY+14)
            {
                this.transform.Translate(0, 0, speedY * Time.deltaTime);
            }
            if (t >= 28.15 / speedY + 14 & t < 28.15 / speedY + 14.5)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }



            if (t > 28.15 / speedY+14.5 & t < 28.75 / speedY+14.5)
            {
                this.transform.Translate(0, -speedY * Time.deltaTime, 0);
            }
            if (t >= 28.75 / speedY + 14.5 & t < 28.75 / speedY + 15)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }


            if (t >= 28.75 / speedY+15 & t < 29.55 / speedY+15)
            {
                this.transform.Translate(0, 0, speedY * Time.deltaTime);
            }
            if (t >= 29.55 / speedY + 15 & t < 29.55 / speedY + 15.5)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }


            if (t >= 29.55 / speedY+15.5 & t <= 30.15 / speedY+15.5)
            {
                this.transform.Translate(0, speedY * Time.deltaTime, 0);
            }
            if (t >= 30.15 / speedY + 15.5 & t <30.15 / speedY + 16)
            {
                speedY = 0;
            }
            else
            {
                speedY = 0.3f;
            }


            if (t >= 30.15 / speedY + 15.5 & t <= 31.15 / speedY + 15.5)
            {
                this.transform.Translate(0, 0, speedY * Time.deltaTime);
                
            }

            if(t> 31.15 / speedY + 15.5 & t<33.15/speedY+15.5)
            {
                m_Offset.x = 0;
                m_Offset.y = 0;
                m_Offset.z = -speedY * Time.deltaTime;
                this.transform.position=this.transform.position+m_Offset;
                this.transform.Rotate(0, (float)(180 / (2 / speedY)) * Time.deltaTime, 0);
            }
            


            if (t> 32.15 / speedY + 15.5)
            {
                speedX = 0.3f;
                m_Offset.x = 9.9f;
                m_Offset.y = 0.54f;
                m_Offset.z = 6.7f;
                this.transform.position = UnityEngine.Vector3.MoveTowards(transform.position, target2, speedX * Time.deltaTime);
                if(this.transform.position==target2)
                {
                    speedY = 0;
                    speedX = 0;
                    isStart = false;
                }
                
                
            }


        }


    }
}
