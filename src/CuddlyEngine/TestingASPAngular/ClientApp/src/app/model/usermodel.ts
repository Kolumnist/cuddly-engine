export class User {

  constructor(
    public id: number,
    public username: string,
    public password: string
  ) { }
  //Never only save password hash it or something but for testing purposes it is fine now

}


