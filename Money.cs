class Money
{
    privet float money {get;set;}
    public Money(){
        money = 25;
    }

    public string ToString(){
        return money + "$";
    }
    
}