export type Bowler = {
  team: any;
  bowlerId: number;
  bowlerAddress: string;
  bowlerCity: string;
  bowlerState: string;
  bowlerZip: number;
  bowlerPhoneNumber: string;
  bowlerName: string;
  teamName: Team;
};

export type Team = {
  teamId: number;
  teamName: string;
};
