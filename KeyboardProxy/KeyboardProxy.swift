//
//  KeyboardProxy.swift
//  KeyboardProxy
//
//  Created by admin on 6/19/21.
//

import Foundation
import UIKit
import Chat

@objc(KeyboardControllerCallback)
public protocol KeyboardControllerCallback {
    func onKeyPadPressed(text: String?)
    func textLeftOfCusor(text: String?)
    func textRightOfCusor(text: String?)
    func enterKey(text: String?)
    func deleteKey()
    func changeTosymbols()
}

@objc(KeyboardProxy)
public class KeyboardProxy : NSObject, KeyboardControllerDelegate {
    
    private var callback: KeyboardControllerCallback? = nil
    
    @objc
    public func onLaunchKeyboard(viewController: UIViewController, delegate: KeyboardControllerCallback) {
        let vc = Chat.KeyboardController()
        
        callback = delegate
        vc.delegate = self
        vc.modalPresentationStyle = .fullScreen
        
        viewController.present(vc, animated: false, completion: nil)
    }
    
    @objc
    public func onLogin(username: String, os: String, imei: String) {
        let lg = Chat.login(username: username, os: os, imei: imei)
        lg.firstLogin()
    }
    
    public func onKeyPadPressed(text: String?){
        callback?.onKeyPadPressed(text: text)
    }
    
    public func textLeftOfCusor(text: String?){
        callback?.textLeftOfCusor(text: text)
    }
    
    public func textRightOfCusor(text: String?){
        callback?.textRightOfCusor(text: text)
    }
    
    
    public func enterKey(text: String?){
        callback?.enterKey(text: text)
    }

    public func deleteKey(){
        callback?.deleteKey()
    }

    public func changeTosymbols(){
        callback?.changeTosymbols()
    }
    
}
