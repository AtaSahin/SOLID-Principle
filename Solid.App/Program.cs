IMessageSender emailSender = new EmailSender();
IMessageSender smsSender = new SMSSender();


NotificationService emailNotificationService = new NotificationService(emailSender);
NotificationService smsNotificationService = new NotificationService(smsSender);

emailNotificationService.SendNotification("Hello, this is an email notification!");
smsNotificationService.SendNotification("Hello, this is an SMS notification!");