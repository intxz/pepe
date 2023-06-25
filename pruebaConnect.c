#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <sys/socket.h>
#include <arpa/inet.h>

int main() {
    int socket_desc;
    struct sockaddr_in server_addr;
    char server_ip[] = "147.83.117.22";
    int server_port = 50095;

    // Create socket
    socket_desc = socket(AF_INET, SOCK_STREAM, 0);
    if (socket_desc == -1) {
        perror("Failed to create socket");
        return 1;
    }

    // Set up server address
    server_addr.sin_family = AF_INET;
    server_addr.sin_port = htons(server_port);
    if (inet_pton(AF_INET, server_ip, &(server_addr.sin_addr)) <= 0) {
        perror("Invalid address/Address not supported");
        return 1;
    }

    // Connect to the server
    if (connect(socket_desc, (struct sockaddr*)&server_addr, sizeof(server_addr)) < 0) {
        perror("Failed to connect");
        return 1;
    }

    // Connection successful
    printf("Connected to the server!\n");

    // Further code for sending/receiving data

    // Close the socket
    close(socket_desc);

    return 0;
}
