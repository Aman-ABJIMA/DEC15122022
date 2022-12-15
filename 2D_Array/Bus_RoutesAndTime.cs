using System;

class BUSTIMETABLE
{
	
    private string v1;
    private string v2;
    private string v3;
    private string v4;
    public BUSTIMETABLE(string v1, string v2, string v3,string v4)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
        this.v4 = v4;
    }
    public string V1
    { get { return this.v1; } }
    public string V2
    {
        get { return this.v2; }
    }
    public string V3
    { get { return this.v3; } }
    public string V4
    { get { return this.v4; } }
}
