export class Crew{
    public UserId: string | undefined;
    public RobotIds: string[] | undefined;

    constructor(init?: Partial<Crew>){
        Object.assign(this, init);
    }
}