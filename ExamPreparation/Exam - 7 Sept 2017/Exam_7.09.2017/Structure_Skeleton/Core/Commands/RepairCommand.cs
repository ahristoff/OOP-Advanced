using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class RepairCommand : Command
{
    private IProviderController providerController;

    public RepairCommand(IList<string> args, IProviderController providerController) : base(args)
    {
        this.providerController = providerController;
    }

    public override string Execute()
    {
        var val = double.Parse(this.Arguments[0]);
        var res = this.providerController.Repair(val);

        return res;
    }
}

