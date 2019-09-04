
Pod::Spec.new do |s|
  s.name         = "RNReactNativeIosWifi"
  s.version      = "1.0.0"
  s.summary      = "Native module for iOS Wifi"
  s.homepage     = "https://github.com/chungw51993/react-native-ios-wifi"
  s.license      = "MIT"
  s.author             = { "author" => "author@domain.cn" }
  s.platform     = :ios, "11.0"
  s.source       = { :git => "https://github.com/chungw51993/react-native-ios-wifi.git", :tag => "master" }
  s.source_files  = "RNReactNativeIosWifi/**/*.{h,m}"
  s.requires_arc = true
  s.frameworks = 'UIKit'


  s.dependency "React"

end

