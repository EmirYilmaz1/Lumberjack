using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwnedItems : MonoBehaviour
{
    [SerializeField] List<ComputerType> ownedComputers = new List<ComputerType>();
    public List<ComputerType> CheckOwnedComputer()
    {
        return ownedComputers;
    }

    [SerializeField] List<RugsType>  ownedRugs = new List<RugsType>();
    public List<RugsType> CheckOwnedRugs()
    {
        return ownedRugs;
    }

    [SerializeField] List<BedType> ownedBed = new List<BedType>();
    public List<BedType> CheckOwnedBed()
    {
        return ownedBed;
    }



    public void AddComputer(ComputerType computerType)
    {
        ownedComputers.Add(computerType);
    }

    public void AddRug(RugsType rugsType)
    {
        ownedRugs.Add(rugsType);
    }
}
