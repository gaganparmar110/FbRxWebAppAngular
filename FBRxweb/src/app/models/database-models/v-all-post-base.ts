import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vAllPostBase {

//#region userId Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'userId', keyColumn: true})
        userId : number;
//#endregion userId Prop


//#region postId Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'postId', keyColumn: false})
        postId : number;
//#endregion postId Prop


//#region userName Prop
        @gridColumn({visible: true, columnIndex:3, allowSorting: true, headerKey: 'userName', keyColumn: false})
        userName : string;
//#endregion userName Prop


//#region post Prop
        @gridColumn({visible: true, columnIndex:4, allowSorting: true, headerKey: 'post', keyColumn: false})
        post : string;
//#endregion post Prop


//#region totalLike Prop
        @gridColumn({visible: true, columnIndex:5, allowSorting: true, headerKey: 'totalLike', keyColumn: false})
        totalLike : number;
//#endregion totalLike Prop


//#region totalComment Prop
        @gridColumn({visible: true, columnIndex:6, allowSorting: true, headerKey: 'totalComment', keyColumn: false})
        totalComment : number;
//#endregion totalComment Prop


//#region totalShare Prop
        @gridColumn({visible: true, columnIndex:7, allowSorting: true, headerKey: 'totalShare', keyColumn: false})
        totalShare : number;
//#endregion totalShare Prop


//#region createdDateTime Prop
        @gridColumn({visible: true, columnIndex:8, allowSorting: true, headerKey: 'createdDateTime', keyColumn: false})
        createdDateTime : any;
//#endregion createdDateTime Prop

}