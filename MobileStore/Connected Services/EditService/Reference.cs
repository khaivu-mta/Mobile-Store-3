﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MobileStore.EditService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EditService.IEditService")]
    public interface IEditService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEditService/Edit_admin", ReplyAction="http://tempuri.org/IEditService/Edit_adminResponse")]
        string Edit_admin(string token, int admin_id, int id, string _username, string _pwd, string _email, string _address, string _phone, System.Nullable<int> _level, string _image, string _fullname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEditService/Edit_admin", ReplyAction="http://tempuri.org/IEditService/Edit_adminResponse")]
        System.Threading.Tasks.Task<string> Edit_adminAsync(string token, int admin_id, int id, string _username, string _pwd, string _email, string _address, string _phone, System.Nullable<int> _level, string _image, string _fullname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEditService/Edit_category", ReplyAction="http://tempuri.org/IEditService/Edit_categoryResponse")]
        string Edit_category(string token, int admin_id, int id, string _name, string _description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEditService/Edit_category", ReplyAction="http://tempuri.org/IEditService/Edit_categoryResponse")]
        System.Threading.Tasks.Task<string> Edit_categoryAsync(string token, int admin_id, int id, string _name, string _description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEditService/Edit_comment", ReplyAction="http://tempuri.org/IEditService/Edit_commentResponse")]
        string Edit_comment(string utoken, int user_id, int id, System.Nullable<int> _product_id, string _comments);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEditService/Edit_comment", ReplyAction="http://tempuri.org/IEditService/Edit_commentResponse")]
        System.Threading.Tasks.Task<string> Edit_commentAsync(string utoken, int user_id, int id, System.Nullable<int> _product_id, string _comments);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEditService/Edit_discount", ReplyAction="http://tempuri.org/IEditService/Edit_discountResponse")]
        string Edit_discount(string token, int admin_id, int id, string _value, string _name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEditService/Edit_discount", ReplyAction="http://tempuri.org/IEditService/Edit_discountResponse")]
        System.Threading.Tasks.Task<string> Edit_discountAsync(string token, int admin_id, int id, string _value, string _name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEditService/Edit_image", ReplyAction="http://tempuri.org/IEditService/Edit_imageResponse")]
        string Edit_image(string token, int admin_id, int id, string _url, System.Nullable<int> _product_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEditService/Edit_image", ReplyAction="http://tempuri.org/IEditService/Edit_imageResponse")]
        System.Threading.Tasks.Task<string> Edit_imageAsync(string token, int admin_id, int id, string _url, System.Nullable<int> _product_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEditService/Edit_post", ReplyAction="http://tempuri.org/IEditService/Edit_postResponse")]
        string Edit_post(string token, int admin_id, int id, System.Nullable<int> _product_id, string _name, string _descripton);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEditService/Edit_post", ReplyAction="http://tempuri.org/IEditService/Edit_postResponse")]
        System.Threading.Tasks.Task<string> Edit_postAsync(string token, int admin_id, int id, System.Nullable<int> _product_id, string _name, string _descripton);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEditService/Edit_product", ReplyAction="http://tempuri.org/IEditService/Edit_productResponse")]
        string Edit_product(
                    string token, 
                    int admin_id, 
                    int id, 
                    string _sku, 
                    string _name, 
                    string _price, 
                    string _Ghz, 
                    string _color, 
                    string _sensor, 
                    string _cpu, 
                    string _ram, 
                    string _storage, 
                    string _camera_front, 
                    string _camera_rear, 
                    string _battery, 
                    string _display, 
                    string _sim, 
                    string _status, 
                    System.Nullable<int> _activate, 
                    System.Nullable<int> _product_cate_id, 
                    System.Nullable<int> _discount_id, 
                    string _image);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEditService/Edit_product", ReplyAction="http://tempuri.org/IEditService/Edit_productResponse")]
        System.Threading.Tasks.Task<string> Edit_productAsync(
                    string token, 
                    int admin_id, 
                    int id, 
                    string _sku, 
                    string _name, 
                    string _price, 
                    string _Ghz, 
                    string _color, 
                    string _sensor, 
                    string _cpu, 
                    string _ram, 
                    string _storage, 
                    string _camera_front, 
                    string _camera_rear, 
                    string _battery, 
                    string _display, 
                    string _sim, 
                    string _status, 
                    System.Nullable<int> _activate, 
                    System.Nullable<int> _product_cate_id, 
                    System.Nullable<int> _discount_id, 
                    string _image);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEditService/Edit_review", ReplyAction="http://tempuri.org/IEditService/Edit_reviewResponse")]
        string Edit_review(string utoken, int user_id, int id, System.Nullable<int> _product_id, string _reviews);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEditService/Edit_review", ReplyAction="http://tempuri.org/IEditService/Edit_reviewResponse")]
        System.Threading.Tasks.Task<string> Edit_reviewAsync(string utoken, int user_id, int id, System.Nullable<int> _product_id, string _reviews);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEditService/Edit_user", ReplyAction="http://tempuri.org/IEditService/Edit_userResponse")]
        string Edit_user(string utoken, int id, System.Nullable<int> admin_id, string _username, string _fullname, string _pwd, string _email, string _address, string _phone, string _image, System.Nullable<int> _activated);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEditService/Edit_user", ReplyAction="http://tempuri.org/IEditService/Edit_userResponse")]
        System.Threading.Tasks.Task<string> Edit_userAsync(string utoken, int id, System.Nullable<int> admin_id, string _username, string _fullname, string _pwd, string _email, string _address, string _phone, string _image, System.Nullable<int> _activated);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEditService/Edit_token", ReplyAction="http://tempuri.org/IEditService/Edit_tokenResponse")]
        string Edit_token(string utoken, int user_id, string _value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEditService/Edit_token", ReplyAction="http://tempuri.org/IEditService/Edit_tokenResponse")]
        System.Threading.Tasks.Task<string> Edit_tokenAsync(string utoken, int user_id, string _value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEditServiceChannel : MobileStore.EditService.IEditService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EditServiceClient : System.ServiceModel.ClientBase<MobileStore.EditService.IEditService>, MobileStore.EditService.IEditService {
        
        public EditServiceClient() {
        }
        
        public EditServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EditServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EditServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EditServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Edit_admin(string token, int admin_id, int id, string _username, string _pwd, string _email, string _address, string _phone, System.Nullable<int> _level, string _image, string _fullname) {
            return base.Channel.Edit_admin(token, admin_id, id, _username, _pwd, _email, _address, _phone, _level, _image, _fullname);
        }
        
        public System.Threading.Tasks.Task<string> Edit_adminAsync(string token, int admin_id, int id, string _username, string _pwd, string _email, string _address, string _phone, System.Nullable<int> _level, string _image, string _fullname) {
            return base.Channel.Edit_adminAsync(token, admin_id, id, _username, _pwd, _email, _address, _phone, _level, _image, _fullname);
        }
        
        public string Edit_category(string token, int admin_id, int id, string _name, string _description) {
            return base.Channel.Edit_category(token, admin_id, id, _name, _description);
        }
        
        public System.Threading.Tasks.Task<string> Edit_categoryAsync(string token, int admin_id, int id, string _name, string _description) {
            return base.Channel.Edit_categoryAsync(token, admin_id, id, _name, _description);
        }
        
        public string Edit_comment(string utoken, int user_id, int id, System.Nullable<int> _product_id, string _comments) {
            return base.Channel.Edit_comment(utoken, user_id, id, _product_id, _comments);
        }
        
        public System.Threading.Tasks.Task<string> Edit_commentAsync(string utoken, int user_id, int id, System.Nullable<int> _product_id, string _comments) {
            return base.Channel.Edit_commentAsync(utoken, user_id, id, _product_id, _comments);
        }
        
        public string Edit_discount(string token, int admin_id, int id, string _value, string _name) {
            return base.Channel.Edit_discount(token, admin_id, id, _value, _name);
        }
        
        public System.Threading.Tasks.Task<string> Edit_discountAsync(string token, int admin_id, int id, string _value, string _name) {
            return base.Channel.Edit_discountAsync(token, admin_id, id, _value, _name);
        }
        
        public string Edit_image(string token, int admin_id, int id, string _url, System.Nullable<int> _product_id) {
            return base.Channel.Edit_image(token, admin_id, id, _url, _product_id);
        }
        
        public System.Threading.Tasks.Task<string> Edit_imageAsync(string token, int admin_id, int id, string _url, System.Nullable<int> _product_id) {
            return base.Channel.Edit_imageAsync(token, admin_id, id, _url, _product_id);
        }
        
        public string Edit_post(string token, int admin_id, int id, System.Nullable<int> _product_id, string _name, string _descripton) {
            return base.Channel.Edit_post(token, admin_id, id, _product_id, _name, _descripton);
        }
        
        public System.Threading.Tasks.Task<string> Edit_postAsync(string token, int admin_id, int id, System.Nullable<int> _product_id, string _name, string _descripton) {
            return base.Channel.Edit_postAsync(token, admin_id, id, _product_id, _name, _descripton);
        }
        
        public string Edit_product(
                    string token, 
                    int admin_id, 
                    int id, 
                    string _sku, 
                    string _name, 
                    string _price, 
                    string _Ghz, 
                    string _color, 
                    string _sensor, 
                    string _cpu, 
                    string _ram, 
                    string _storage, 
                    string _camera_front, 
                    string _camera_rear, 
                    string _battery, 
                    string _display, 
                    string _sim, 
                    string _status, 
                    System.Nullable<int> _activate, 
                    System.Nullable<int> _product_cate_id, 
                    System.Nullable<int> _discount_id, 
                    string _image) {
            return base.Channel.Edit_product(token, admin_id, id, _sku, _name, _price, _Ghz, _color, _sensor, _cpu, _ram, _storage, _camera_front, _camera_rear, _battery, _display, _sim, _status, _activate, _product_cate_id, _discount_id, _image);
        }
        
        public System.Threading.Tasks.Task<string> Edit_productAsync(
                    string token, 
                    int admin_id, 
                    int id, 
                    string _sku, 
                    string _name, 
                    string _price, 
                    string _Ghz, 
                    string _color, 
                    string _sensor, 
                    string _cpu, 
                    string _ram, 
                    string _storage, 
                    string _camera_front, 
                    string _camera_rear, 
                    string _battery, 
                    string _display, 
                    string _sim, 
                    string _status, 
                    System.Nullable<int> _activate, 
                    System.Nullable<int> _product_cate_id, 
                    System.Nullable<int> _discount_id, 
                    string _image) {
            return base.Channel.Edit_productAsync(token, admin_id, id, _sku, _name, _price, _Ghz, _color, _sensor, _cpu, _ram, _storage, _camera_front, _camera_rear, _battery, _display, _sim, _status, _activate, _product_cate_id, _discount_id, _image);
        }
        
        public string Edit_review(string utoken, int user_id, int id, System.Nullable<int> _product_id, string _reviews) {
            return base.Channel.Edit_review(utoken, user_id, id, _product_id, _reviews);
        }
        
        public System.Threading.Tasks.Task<string> Edit_reviewAsync(string utoken, int user_id, int id, System.Nullable<int> _product_id, string _reviews) {
            return base.Channel.Edit_reviewAsync(utoken, user_id, id, _product_id, _reviews);
        }
        
        public string Edit_user(string utoken, int id, System.Nullable<int> admin_id, string _username, string _fullname, string _pwd, string _email, string _address, string _phone, string _image, System.Nullable<int> _activated) {
            return base.Channel.Edit_user(utoken, id, admin_id, _username, _fullname, _pwd, _email, _address, _phone, _image, _activated);
        }
        
        public System.Threading.Tasks.Task<string> Edit_userAsync(string utoken, int id, System.Nullable<int> admin_id, string _username, string _fullname, string _pwd, string _email, string _address, string _phone, string _image, System.Nullable<int> _activated) {
            return base.Channel.Edit_userAsync(utoken, id, admin_id, _username, _fullname, _pwd, _email, _address, _phone, _image, _activated);
        }
        
        public string Edit_token(string utoken, int user_id, string _value) {
            return base.Channel.Edit_token(utoken, user_id, _value);
        }
        
        public System.Threading.Tasks.Task<string> Edit_tokenAsync(string utoken, int user_id, string _value) {
            return base.Channel.Edit_tokenAsync(utoken, user_id, _value);
        }
    }
}
