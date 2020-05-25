import { GenderModel } from "../gender/gender.model";
import { SkillModel } from "../skill/skill.model";

export class EmployeeModel {
  id: number = 0;
  name: string;
  lastName: string;
  birthDate: Date;
  
  genderId: number = 0;
  gender: GenderModel;

  skills: SkillModel[];
}
