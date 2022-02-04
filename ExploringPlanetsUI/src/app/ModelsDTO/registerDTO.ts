export class Register{
    public Id: string | undefined;
    public FirstName: string | undefined;
    public LastName: string | undefined;
    public Email: string | undefined;
    public Password: string | undefined;
    public Role: string | undefined;

    constructor(init?: Partial<Register>){
        Object.assign(this, init);
        this.Role = 'Captain';
    }
}