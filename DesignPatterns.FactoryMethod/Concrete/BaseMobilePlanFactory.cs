using System;
using DesignPatterns.FactoryMethod.Interfaces;

namespace DesignPatterns.FactoryMethod.Concrete
{
    //O padrao considera uma boa pratica criar a factory base como abstrata
    public abstract class BaseMobilePlanFactory
    {

        //O padrao considera uma boa pratica criar um metodo responsavel
        //por chamar as factorys de cada classe concreta
        public IMobilePlan GetMobilePlan()
        {
            //this.CreateMobilePlan(): refere-se ao metodo implementado na classe
            //que estará herdando dessa classe abstrata
            var mobilePlan = this.CreateMobilePlan();

            return mobilePlan;
        }

        //método que devera ser implementado pela classes que herdarem esta
        public abstract IMobilePlan CreateMobilePlan();
    }
}
