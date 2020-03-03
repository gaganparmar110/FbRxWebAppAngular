import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vUserProfileBase {

//#region userId Prop
        @gridColumn({visible: true, columnIndex:0, allowSorting: true, headerKey: 'userId', keyColumn: true})
        userId : number;
//#endregion userId Prop


//#region firstName Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'firstName', keyColumn: false})
        firstName : string;
//#endregion firstName Prop


//#region lastName Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'lastName', keyColumn: false})
        lastName : string;
//#endregion lastName Prop


//#region currentCity Prop
        @gridColumn({visible: true, columnIndex:3, allowSorting: true, headerKey: 'currentCity', keyColumn: false})
        currentCity : string;
//#endregion currentCity Prop


//#region homeTown Prop
        @gridColumn({visible: true, columnIndex:4, allowSorting: true, headerKey: 'homeTown', keyColumn: false})
        homeTown : string;
//#endregion homeTown Prop


//#region bio Prop
        @gridColumn({visible: true, columnIndex:5, allowSorting: true, headerKey: 'bio', keyColumn: false})
        bio : string;
//#endregion bio Prop


//#region relationship Prop
        @gridColumn({visible: true, columnIndex:6, allowSorting: true, headerKey: 'relationship', keyColumn: false})
        relationship : string;
//#endregion relationship Prop


//#region cover Prop
        @gridColumn({visible: true, columnIndex:7, allowSorting: true, headerKey: 'cover', keyColumn: false})
        cover : string;
//#endregion cover Prop


//#region profilephoto Prop
        @gridColumn({visible: true, columnIndex:8, allowSorting: true, headerKey: 'profilephoto', keyColumn: false})
        profilephoto : string;
//#endregion profilephoto Prop

}