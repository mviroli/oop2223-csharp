public class DomusController{
    
    private Lamp[] _lamps;
    private TV[] _tvs;
    private AirConditioner[] _airs;
    private Radio[] _radios;
    
    ...
    public void SwitchAll(bool on){
    	for (var lamp in this.lamps){
    	    if (on) lamp?.SwitchOn(); else lamp?.SwitchOff();
    	}
    	for (var tv in this.tvs){
    	    if (on) tv?.SwitchOn(); else tv?.SwitchOff();
    	}
    	... // and so on for all devices?
    }
 
}
