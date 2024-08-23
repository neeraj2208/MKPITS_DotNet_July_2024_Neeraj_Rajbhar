#include <stdio.h>

int main() {
    int m_maths,m_phy,m_chem,m_mp,m_tot;
    printf("Enter the marks of Maths :");
    scanf("%d",&m_maths);
    printf("Enter the marks of Physic :");
    scanf("%d",&m_phy);
    printf("Enter the marks of Chemistry :");
    scanf("%d",&m_chem);
    
    m_tot=m_maths+m_phy+m_chem;
    printf("The total marks are :%d\n",m_tot);
    
    m_mp=m_maths+m_phy;
    printf("Total in Maths and Physic are :%d\n",m_mp);
    
    if(m_maths>65 && m_phy>55 && m_chem>50)
    {
        if(m_tot>=190 || m_mp>=140)
        {
            printf("The candidate is eligible for admission.");
        }
    }
    else
    {
        printf("The candidate is not eligible for admission.");
    }
    
    

    return 0;
}