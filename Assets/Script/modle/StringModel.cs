using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class StringModel : Basemodel {
    public string myString;
    public bool isTrue;
    public StringModel(string T ,bool b){ myString = T;isTrue = b; }

    
    public StringModel() {
        isTrue = false;
        myString = ""; }

    }

