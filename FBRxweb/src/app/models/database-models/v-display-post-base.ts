import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vDisplayPostBase {

//#region postId Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'postId', keyColumn: true})
        postId : number;
//#endregion postId Prop


//#region firstName Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'firstName', keyColumn: false})
        firstName : string;
//#endregion firstName Prop


//#region posts Prop
        @gridColumn({visible: true, columnIndex:3, allowSorting: true, headerKey: 'posts', keyColumn: false})
        posts : string;
//#endregion posts Prop


//#region postDateTime Prop
        @gridColumn({visible: true, columnIndex:4, allowSorting: true, headerKey: 'postDateTime', keyColumn: false})
        postDateTime : any;
//#endregion postDateTime Prop

}