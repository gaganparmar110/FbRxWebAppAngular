import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vBasicDetailBase {

//#region firstName Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'firstName', keyColumn: false})
        firstName : string;
//#endregion firstName Prop


//#region currentCity Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'currentCity', keyColumn: false})
        currentCity : string;
//#endregion currentCity Prop


//#region relationshipAO Prop
        @gridColumn({visible: true, columnIndex:3, allowSorting: true, headerKey: 'relationshipAO', keyColumn: false})
        relationshipAO : any;
//#endregion relationshipAO Prop


//#region bio Prop
        @gridColumn({visible: true, columnIndex:4, allowSorting: true, headerKey: 'bio', keyColumn: false})
        bio : string;
//#endregion bio Prop


//#region profilePhotoId Prop
        @gridColumn({visible: true, columnIndex:5, allowSorting: true, headerKey: 'profilePhotoId', keyColumn: false})
        profilePhotoId : any;
//#endregion profilePhotoId Prop


//#region coverPhotoId Prop
        @gridColumn({visible: true, columnIndex:6, allowSorting: true, headerKey: 'coverPhotoId', keyColumn: false})
        coverPhotoId : any;
//#endregion coverPhotoId Prop

}