function ertekel(x,nev)
{
    document.getElementById(`${nev}`).innerHTML=""
    let csillag = x
    let ures = 5-x
    let value = 1;
    for (let index = 0; index < csillag; index++)
    {
        document.getElementById(`${nev}`).innerHTML+= `<button onmouseover=\"ertekel(${value},${nev})\" ><img src=\"kepek/csillag.png\" alt=\"\"></button>`
        value++
    }
    for (let index = 0; index < ures; index++)
    {
        document.getElementById(`${nev}`).innerHTML+= `<button onmouseover=\"ertekel(${value},${nev})\" ><img src=\"kepek/urescsillag.png\" alt=\"\"></button>`
        value++
    }
}