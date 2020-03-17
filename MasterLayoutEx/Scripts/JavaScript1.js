function func1()
{
    var eno = document.getElementById("EMPNO").value;
    window.location.href = "/BindingEx/Update/" + eno;
    //alert("/BindingEx/Update/" + eno);
}