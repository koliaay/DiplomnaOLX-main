import * as React from 'react';
import { useLocation} from 'react-router-dom';

type MyParams = {
    search: string;
}
const Resetpassword = () => {
    const  code  = useLocation<MyParams>();
    var t = new URLSearchParams(code.search)
    console.log("code", t.get("code"));
    console.log("userId", t.get("userId"));
    return (
    <div>
        <h1>Відновлення паролю --</h1>
   
    </div>
    )

  
    };

export default Resetpassword;
