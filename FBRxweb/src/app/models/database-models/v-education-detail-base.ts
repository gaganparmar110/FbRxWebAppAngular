import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vEducationDetailBase {

//#region courseName Prop
        @gridColumn({visible: true, columnIndex:0, allowSorting: true, headerKey: 'courseName', keyColumn: false})
        courseName : string;
//#endregion courseName Prop


//#region collegeSchoolName Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'collegeSchoolName', keyColumn: false})
        collegeSchoolName : string;
//#endregion collegeSchoolName Prop


//#region universityBoardName Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'universityBoardName', keyColumn: false})
        universityBoardName : string;
//#endregion universityBoardName Prop


//#region applicationObjectName Prop
        @gridColumn({visible: true, columnIndex:3, allowSorting: true, headerKey: 'applicationObjectName', keyColumn: false})
        applicationObjectName : string;
//#endregion applicationObjectName Prop


//#region city Prop
        @gridColumn({visible: true, columnIndex:4, allowSorting: true, headerKey: 'city', keyColumn: false})
        city : string;
//#endregion city Prop


//#region userId Prop
        @gridColumn({visible: true, columnIndex:5, allowSorting: true, headerKey: 'userId', keyColumn: true})
        userId : number;
//#endregion userId Prop

}